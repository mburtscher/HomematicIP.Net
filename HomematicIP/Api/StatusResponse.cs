using HomematicIP.Domain;

namespace HomematicIP.Api;

public class StatusResponseBody
{
    public bool Success { get; set; }
    public List<Device> Devices { get; set; } = new List<Device>();
}

public class StatusResponse : PluginMessage<StatusResponseBody>
{
}
