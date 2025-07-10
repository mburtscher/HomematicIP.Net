namespace HomematicIP.Api;

public class StatusRequest : PluginMessage<StatusRequestBody>
{
}

public class StatusRequestBody
{
    public List<Guid> DeviceIds { get; set; } = new List<Guid>();
}
