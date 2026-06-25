namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing general maintenance functions of a plugin device.
/// </summary>
public class MaintenanceFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device’s battery is low.
    /// </summary>
    public bool? LowBat { get; set; }

    /// <summary>
    /// Flag to indicate whether the sabotage contact sensor of the device is triggered.
    /// </summary>
    public bool? Sabotage { get; set; }

    /// <summary>
    /// Flag to indicate whether the device is currently unreachable.
    /// </summary>
    public bool? Unreach { get; set; }
}
