namespace HomematicIP.Api;

public class InclusionEvent : PluginMessage<InclusionEventBody>
{
}
public class InclusionEventBody
{
    public List<Guid> DeviceIds { get; set; } = new List<Guid>();
}
