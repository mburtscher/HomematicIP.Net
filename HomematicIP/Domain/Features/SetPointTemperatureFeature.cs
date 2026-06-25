namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the target temperature set in a plugin device.
/// </summary>
public class SetPointTemperatureFeature : FeatureBase
{
    private double? setPointTemperature;

    /// <summary>
    /// The target temperature in °C the device is currently set to.
    /// </summary>
    public double? SetPointTemperature
    {
        get => setPointTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, -50);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 60);
            }
            
            setPointTemperature = value;
        }
    }
}
