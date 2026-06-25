namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the current illumination measured by a plugin device.
/// </summary>
public class IlluminationFeature : FeatureBase
{
    private double? illumination;

    /// <summary>
    /// The current illumination in lux.
    /// </summary>
    public double? Illumination
    {
        get => illumination;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 20000);
            }
            
            illumination = value;
        }
    }
}
