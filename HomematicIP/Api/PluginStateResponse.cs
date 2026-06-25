using HomematicIP.Domain;
using HomematicIP.Domain.Types;

namespace HomematicIP.Api;


public class PluginStateResponse : PluginMessage<PluginStateResponseBody>
{
}
public class PluginStateResponseBody
{
    public PluginReadinessStatus PluginReadinessStatus { get; set; }
    public Dictionary<string, string> FriendlyName { get; set; } = new Dictionary<string, string>();
}
