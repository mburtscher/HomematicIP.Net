namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the contact sensor state of a plugin device.
/// </summary>
public class ContactSensorStateFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the contact sensor is triggered.
    /// </summary>
    public bool? Triggered { get; set; }
}
