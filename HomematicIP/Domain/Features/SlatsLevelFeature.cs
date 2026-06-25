namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the slats level of a plugin device.
/// </summary>
public class SlatsLevelFeature : FeatureBase
{
    private double? slatsLevel;

    /// <summary>
    /// The slats level of the device in a range from 0 - 1. 1 is fully closed. Possible special values are 1.005 for the last value and 1.01 as the ignore value.
    /// </summary>
    public double? SlatsLevel
    {
        get => slatsLevel;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 1.01);
            }
            
            slatsLevel = value;
        }
    }
}
