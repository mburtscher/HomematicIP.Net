using HomematicIP.Domain;

namespace HomematicIP.Api;

public class DiscoverResponseBody
{
    public bool Success { get; set; }
    public List<Device> Devices { get; set; } = new List<Device>();
}

public class DiscoverResponse : PluginMessage<DiscoverResponseBody>
{
}
