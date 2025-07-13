namespace HomematicIP.Api;

public class PluginStateRequest : PluginMessage<PluginStateRequestBody>
{
}

public class PluginStateRequestBody
{
    public List<string>? DeviceIds { get; set; }
}
