namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the light color of a plugin device.
/// </summary>
public class ColorFeature : FeatureBase
{
    private int? hue;
    private double? saturationLevel;

    /// <summary>
    /// The hue color value in degrees on the color wheel. Special values are 360 for the last value and 361 as the ignore value.
    /// </summary>
    public int? Hue
    {
        get => hue;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 361);
            }
            
            hue = value;
        }
    }

    /// <summary>
    /// The color intensity. Special values are 1.005 for the last value and 1.01 as the ignore value.
    /// </summary>
    public double? SaturationLevel
    {
        get => saturationLevel;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
                ArgumentOutOfRangeException.ThrowIfGreaterThan(value.Value, 1);
            }
            
            saturationLevel = value;
        }
    }
}
