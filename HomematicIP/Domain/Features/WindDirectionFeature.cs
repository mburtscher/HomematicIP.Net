namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the wind direction measured by a plugin device.
/// </summary>
public class WindDirectionFeature : FeatureBase
{
    private double? windDirection;

    /// <summary>
    /// The current wind direction in °.
    /// </summary>
    public double? WindDirection
    {
        get => windDirection;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 359);
            }
            
            windDirection = value;
        }
    }
}
