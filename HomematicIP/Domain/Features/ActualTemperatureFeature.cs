namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the actual temperature measured by a plugin device in °C.
/// </summary>
public class ActualTemperatureFeature : FeatureBase
{
    private double? actualTemperature;

    /// <summary>
    /// The current temperature in °C.
    /// </summary>
    public double? ActualTemperature
    {
        get => actualTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, -50);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 60);
            }

            actualTemperature = value;
        }
    }
}
