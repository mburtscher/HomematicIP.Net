namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing carbon dioxide concentration measured by a plugin device.
/// </summary>
public class CO2ConcentrationFeature : FeatureBase
{
    private double? co2;

    /// <summary>
    /// The carbon dioxide concentration in ppm.
    /// </summary>
    public double? Co2
    {
        get => co2;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }

            co2 = value;
        }
    }
}
