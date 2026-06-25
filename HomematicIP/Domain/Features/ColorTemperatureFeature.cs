namespace HomematicIP.Domain.Features;

public class ColorTemperatureFeature : FeatureBase
{
    private int? colorTemperature;
    private int? maximumColorTemperature;
    private int? minimalColorTemperature;

    public int? ColorTemperature
    {
        get => colorTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            colorTemperature = value;
        }
    }

    public int? MaximumColorTemperature
    {
        get => maximumColorTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            maximumColorTemperature = value;
        }
    }

    public int? MinimalColorTemperature
    {
        get => minimalColorTemperature;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            minimalColorTemperature = value;
        }
    }
}
