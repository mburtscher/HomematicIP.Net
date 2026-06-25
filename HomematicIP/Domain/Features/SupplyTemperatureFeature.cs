namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the supply temperature of a plugin device.
/// </summary>
public class SupplyTemperatureFeature : FeatureBase
{
    private double? supplyTemperature;

    /// <summary>
    /// The current supply temperature in °C.
    /// </summary>
    public double? SupplyTemperature
    {
        get => supplyTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, -50);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 60);
            }
            
            supplyTemperature = value;
        }
    }
}
