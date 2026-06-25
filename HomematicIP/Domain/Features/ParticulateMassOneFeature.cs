namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the mass concentration of particulate matter of size PM 1 measured by a plugin device.
/// </summary>
public class ParticulateMassOneFeature : FeatureBase
{
    private double? particulateMassConcentrationOne;
    private double? particulateMassConcentrationOneAverage;
    private double? particulateNumberConcentrationOne;

    /// <summary>
    /// The mass concentration of particulate matter of size PM 1 in µg/m3.
    /// </summary>
    public double? ParticulateMassConcentrationOne
    {
        get => particulateMassConcentrationOne;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationOne = value;
        }
    }

    /// <summary>
    /// The average mass concentration of particulate matter of size PM 1 in µg/m3 over 24 h.
    /// </summary>
    public double? ParticulateMassConcentrationOneAverage
    {
        get => particulateMassConcentrationOneAverage;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationOneAverage = value;
        }
    }

    /// <summary>
    /// The number concentration of particulate matter of size PM 1 µg/cm3.
    /// </summary>
    public double? ParticulateNumberConcentrationOne
    {
        get => particulateNumberConcentrationOne;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateNumberConcentrationOne = value;
        }
    }
}
