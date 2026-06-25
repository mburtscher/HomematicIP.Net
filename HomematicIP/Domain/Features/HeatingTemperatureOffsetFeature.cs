namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing heating offset of a plugin device.
/// </summary>
public class HeatingTemperatureOffsetFeature : FeatureBase
{
    private double? heatingTemperatureOffset;

    /// <summary>
    /// The heating temperature offset in °C.
    /// </summary>
    public double? HeatingTemperatureOffset
    {
        get => heatingTemperatureOffset;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, -50);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 50);
            }
            
            heatingTemperatureOffset = value;
        }
    }
}
