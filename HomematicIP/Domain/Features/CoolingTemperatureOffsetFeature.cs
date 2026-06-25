namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the cooling offset temperature of a plugin device.
/// </summary>
public class CoolingTemperatureOffsetFeature : FeatureBase
{
    private double? coolingTemperatureOffset;

    /// <summary>
    /// The cooling temperature offset in °C.
    /// </summary>
    public double? CoolingTemperatureOffset
    {
        get => coolingTemperatureOffset;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, -50);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 50);
            }
            
            coolingTemperatureOffset = value;
        }
    }
}
