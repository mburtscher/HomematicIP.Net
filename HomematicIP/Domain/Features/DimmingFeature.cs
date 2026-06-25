namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing dimming value of a plugin device.
/// </summary>
public class DimmingFeature : FeatureBase
{
    private double? dimLevel;

    /// <summary>
    /// The target brightness level. 1.005 is the special value for last value, if supported. 1.01 is the special value for ignore value, if supported.
    /// </summary>
    public double? DimLevel
    {
        get => dimLevel;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 1);
            }
            
            dimLevel = value;
        }
    }
}
