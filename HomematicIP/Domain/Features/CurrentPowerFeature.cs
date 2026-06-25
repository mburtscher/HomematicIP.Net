namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the currently used or produced power of a plugin device.
/// </summary>
public class CurrentPowerFeature : FeatureBase
{
    /// <summary>
    /// The currently consumed or produced power in W. May be negative or positive, depending on the specific device.
    /// </summary>
    public int? CurrentPower { get; set; }
}
