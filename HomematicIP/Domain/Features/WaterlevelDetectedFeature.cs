namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the water level detection function of a plugin device.
/// </summary>
public class WaterlevelDetectedFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device has recently detected a water level.
    /// </summary>
    public bool? WaterlevelDetected { get; set; }
}
