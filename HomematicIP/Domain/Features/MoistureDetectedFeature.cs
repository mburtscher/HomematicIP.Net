namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the moisture detection function of a plugin device.
/// </summary>
public class MoistureDetectedFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device has recently detected moisture.
    /// </summary>
    public bool? MoistureDetected { get; set; }
}
