namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the battery state of a plugin device.
/// </summary>
public class BatteryStateFeature : FeatureBase
{
    private double? batteryLevel;
    private double? batteryCapacity;

    /// <summary>
    /// The current state of charge of a battery. From 0 to 1 representing the percentage
    /// </summary>
    public double? BatteryLevel
    {
        get => batteryLevel;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 1);
            }

            batteryLevel = value;
        }
    }

    /// <summary>
    /// The capacity of batter in Wh. Ideally the usable capacity, otherwise the nominal capacity.
    /// </summary>
    public double? BatteryCapacity
    {
        get => batteryCapacity;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }

            batteryCapacity = value;
        }
    }
}
