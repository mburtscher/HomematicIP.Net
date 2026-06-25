namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the presence detection function of a plugin device.
/// </summary>
public class PresenceDetectedFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device has recently detected presence.
    /// </summary>
    public bool? PresenceDetected { get; set; }
}
