namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the energy counter of a plugin device.
/// </summary>
public class EnergyCounterFeature : FeatureBase
{
    private double? @in;
    private double? @out;

    /// <summary>
    /// The total amount of energy in kWh that has flown from the home to the device, e.g. the energy put into a battery since resetting the counter.
    /// </summary>
    public double? In
    {
        get => @in;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            @in = value;
        }
    }

    /// <summary>
    /// The total amount of energy in kWh that has flown from the device to the home, e.g. the energy taken from a battery since resetting the counter.
    /// </summary>
    public double? Out
    {
        get => @out;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            @out = value;
        }
    }
}
