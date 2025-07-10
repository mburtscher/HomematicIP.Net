using HomematicIP.Domain.Features;

namespace HomematicIP.Domain;

public class Device
{
    public Guid DeviceId { get; set; }
    public DeviceType DeviceType { get; set; }
    public string? ModelType { get; set; }
    public string? FriendlyName { get; set; }
    public string? FirmwareVersion { get; set; }
    public List<FeatureBase> Features { get; set; } = new List<FeatureBase>();
}
