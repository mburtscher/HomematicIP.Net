namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the shutter level of a plugin device.
/// </summary>
public class ShutterLevelFeature : FeatureBase
{
    private double? shutterLevel;

    /// <summary>
    /// The current shutter level of the device in a range from 0 - 1. 1 is fully closed. Possible special values are 1.005 for the last value and 1.01 as the ignore value.
    /// </summary>
    public double? ShutterLevel
    {
        get => shutterLevel;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 1.01);
            }
            
            shutterLevel = value;
        }
    }
}
