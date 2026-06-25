namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the mass concentration of particulate matter of size PM 2.5 measured by a plugin device.
/// </summary>
public class ParticulateMassTwoPointFiveFeature : FeatureBase
{
    private double? airQualityIndexTwoPointFive;
    private double? particulateMassConcentrationTwoPointFive;
    private double? particulateMassConcentrationTwoPointFiveAverage;
    private double? particulateNumberConcentrationTwoPointFive;
    private double? particulateNumberConcentrationTwoPointFiveAverage;

    /// <summary>
    /// The air quality index of particulate matter of size PM 2.5
    /// </summary>
    public double? AirQualityIndexTwoPointFive
    {
        get => airQualityIndexTwoPointFive;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            airQualityIndexTwoPointFive = value;
        }
    }

    /// <summary>
    /// The mass concentration of particulate matter of size PM 2.5 in µg/m3.
    /// </summary>
    public double? ParticulateMassConcentrationTwoPointFive
    {
        get => particulateMassConcentrationTwoPointFive;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationTwoPointFive = value;
        }
    }

    /// <summary>
    /// The average mass concentration of particulate matter of size PM 2.5 in µg/m3 over 24 h.
    /// </summary>
    public double? ParticulateMassConcentrationTwoPointFiveAverage
    {
        get => particulateMassConcentrationTwoPointFiveAverage;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationTwoPointFiveAverage = value;
        }
    }

    /// <summary>
    /// The number concentration of particulate matter of size PM 2.5 µg/cm3.
    /// </summary>
    public double? ParticulateNumberConcentrationTwoPointFive
    {
        get => particulateNumberConcentrationTwoPointFive;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateNumberConcentrationTwoPointFive = value;
        }
    }

    /// <summary>
    /// The number concentration of particulate matter of size PM 2.5 in µg/m3 over 24 h.
    /// </summary>
    public double? ParticulateNumberConcentrationTwoPointFiveAverage
    {
        get => particulateNumberConcentrationTwoPointFiveAverage;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateNumberConcentrationTwoPointFiveAverage = value;
        }
    }
}
