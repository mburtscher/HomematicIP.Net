namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing sunshine measured by a plugin device.
/// </summary>
public class SunshineFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device currently detects sunshine.
    /// </summary>
    public bool? Sunshine { get; set; }
}
