namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing typical particle size measured by a plugin device.
/// </summary>
public class ParticulateTypicalSizeFeature : FeatureBase
{
    private double? particulateTypicalSize;

    /// <summary>
    /// The typical particle size in 0,01 µm resolution.
    /// </summary>
    public double? ParticulateTypicalSize
    {
        get => particulateTypicalSize;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            particulateTypicalSize = value;
        }
    }
}
