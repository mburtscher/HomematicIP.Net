namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the wind speed measured by a plugin device.
/// </summary>
public class WindSpeedFeature : FeatureBase
{
    private double? windSpeed;

    /// <summary>
    /// The current wind speed in km/h.
    /// </summary>
    public double? WindSpeed
    {
        get => windSpeed;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 400);
            }
            
            windSpeed = value;
        }
    }
}
