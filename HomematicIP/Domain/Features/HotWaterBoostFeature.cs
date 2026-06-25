namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the hot water boost function of a plugin device. Mainly used by heat pumps.
/// </summary>
public class HotWaterBoostFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the hot water boost function is active or not.
    /// </summary>
    public bool? On { get; set; }
}
