namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the mass concentration of particulate matter of size PM 10 measured by a plugin device.
/// </summary>
public class ParticulateMassTenFeature : FeatureBase
{
    private double? airQualityIndexTen;
    private double? particulateMassConcentrationTen;
    private double? particulateMassConcentrationTenAverage;
    private double? particulateNumberConcentrationTen;
    private double? particulateNumberConcentrationTenAverage;

    /// <summary>
    /// The air quality index of particulate matter of size PM 10
    /// </summary>
    public double? AirQualityIndexTen
    {
        get => airQualityIndexTen;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            airQualityIndexTen = value;
        }
    }

    /// <summary>
    /// The mass concentration of particulate matter of size PM 10 in µg/m3.
    /// </summary>
    public double? ParticulateMassConcentrationTen
    {
        get => particulateMassConcentrationTen;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationTen = value;
        }
    }

    /// <summary>
    /// The average mass concentration of particulate matter of size PM 10 in µg/m3 over 24 h.
    /// </summary>
    public double? ParticulateMassConcentrationTenAverage
    {
        get => particulateMassConcentrationTenAverage;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateMassConcentrationTenAverage = value;
        }
    }

    /// <summary>
    /// The number concentration of particulate matter of size PM 10 µg/cm3.
    /// </summary>
    public double? ParticulateNumberConcentrationTen
    {
        get => particulateNumberConcentrationTen;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateNumberConcentrationTen = value;
        }
    }

    /// <summary>
    /// The number concentration of particulate matter of size PM 10 in µg/m3 over 24 h.
    /// </summary>
    public double? ParticulateNumberConcentrationTenAverage
    {
        get => particulateNumberConcentrationTenAverage;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateNumberConcentrationTenAverage = value;
        }
    }
}
