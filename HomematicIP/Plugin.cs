using HomematicIP.Api;
using HomematicIP.Domain;
using System.Diagnostics;
using System.Net.Security;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomematicIP;

public class Plugin
{
    private ClientWebSocket? client;
    private JsonSerializerOptions jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, Converters = { new JsonStringEnumConverter() }, AllowOutOfOrderMetadataProperties = true };
    private Dictionary<Type, Delegate> handlers = new Dictionary<Type, Delegate>();

    public string Id { get; }
    public string? Host { get; set; }
    public string? Token { get; set; }

    public Plugin(string id)
    {
        Id = id;
    }

    public void RegisterHandler<T>(Action<Plugin, T> handler)
        where T : PluginMessage
    {
        handlers[typeof(T)] = handler;
    }

    private void EnsureCredentialsLoaded()
    {
        if (Host == null)
        {
            Host = "host.containers.internal";
        }

        if (Token == null)
        {
            if (File.Exists("/TOKEN"))
            {
                Token = File.ReadAllText("/TOKEN");
            }
            else
            {
                throw new Exception("Token not provided and no token available under /TOKEN.");
            }
        }
    }

    public async Task Start()
    {
        EnsureCredentialsLoaded();

        // Initialize client
        client = new ClientWebSocket();
        client.Options.RemoteCertificateValidationCallback = new RemoteCertificateValidationCallback((sender, certificate, chain, sslPolicyErrors) => true);
        client.Options.SetRequestHeader("authtoken", Token);
        client.Options.SetRequestHeader("plugin-id", Id);

        Uri uri = new Uri($"wss://{Host}:9001");

        try
        {
            await client.ConnectAsync(uri, CancellationToken.None);

            Console.WriteLine("Connected to WebSocket");

            // Send PLUGIN_STATE_RESPONSE upon startup
            await Send(new PluginStateResponse
            {
                Body = new PluginStateResponseBody
                {
                    PluginReadinessStatus = PluginReadinessStatus.READY,
                }
            });

            await ReceiveMessages();
        }
        catch (WebSocketException ex)
        {
            Console.Error.WriteLine($"WebSocket error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
        }

        if (client != null && client.State == WebSocketState.Open)
        {
            await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing", CancellationToken.None);
        }
    }

    private async Task ReceiveMessages()
    {
        byte[] buffer = new byte[4096]; // Increased buffer size for potentially larger messages
        while (client?.State == WebSocketState.Open)
        {
            WebSocketReceiveResult result;
            try
            {
                result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
            }
            catch (WebSocketException ex)
            {
                Console.Error.WriteLine($"WebSocket receive error: {ex.Message}");
                break;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error receiving message: {ex.Message}");
                break;
            }

            if (result.MessageType == WebSocketMessageType.Text)
            {
                string messageString = Encoding.UTF8.GetString(buffer, 0, result.Count);
                Console.WriteLine("[RECEIVE] " + messageString);

                try
                {
                    var message = JsonSerializer.Deserialize<PluginMessage>(messageString, jsonOptions);

                    if (message != null)
                    {
                        Delegate? handler;

                        if (handlers.TryGetValue(message.GetType(), out handler))
                        {
                            handler.DynamicInvoke(this, message);
                        }
                        else
                        {
                            Console.WriteLine($"No handler found for message of type: {message.GetType()}");
                        }
                    }
                }
                catch (JsonException ex)
                {
                    Console.Error.WriteLine($"Error deserializing message: {ex.Message}");
                }
            }
            else if (result.MessageType == WebSocketMessageType.Close)
            {
                Console.WriteLine("WebSocket closed by remote host.");
                await client.CloseAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
            }
        }
    }

    public Task Send(PluginMessage message)
    {
        if (client == null)
        {
            throw new Exception("Plugin has not started yet. Use the .start() method.");
        }

        // Make sure the plugin id is set
        if (string.IsNullOrEmpty(message.PluginId))
        {
            message.PluginId = Id;
        }

        // Make sure a message id is set
        if (message.Id == null)
        {
            message.Id = Guid.NewGuid();
        }

        string jsonMessage = JsonSerializer.Serialize(message, jsonOptions);

        Console.WriteLine($"[SEND] {jsonMessage}");

        var bytes = Encoding.UTF8.GetBytes(jsonMessage);
        return client.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
    }
}
