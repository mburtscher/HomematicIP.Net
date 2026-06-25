namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the humidity value measured by a plugin device.
/// </summary>
public class HumidityFeature : FeatureBase
{
    private int? humidity;

    /// <summary>
    /// The current humidity in %rh.
    /// </summary>
    public int? Humidity
    {
        get => humidity;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 100);
            }
            
            humidity = value;
        }
    }
}
