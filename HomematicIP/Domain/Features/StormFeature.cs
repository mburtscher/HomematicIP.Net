namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the wind speed and direction measured by a plugin device.
/// </summary>
public class StormFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device currently detects storm.
    /// </summary>
    public bool? Storm { get; set; }
}
