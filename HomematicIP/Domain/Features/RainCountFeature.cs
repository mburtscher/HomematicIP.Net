namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the amount of rain measured by a plugin device.
/// </summary>
public class RainCountFeature : FeatureBase
{
    private double? rainCounter;
    private double? todayRainCounter;
    private double? yesterdayRainCounter;

    /// <summary>
    /// The total accumulated amount of rain in mm.
    /// </summary>
    public double? RainCounter
    {
        get => rainCounter;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            rainCounter = value;
        }
    }

    /// <summary>
    /// The accumulated amount of today’s rain in mm.
    /// </summary>
    public double? TodayRainCounter
    {
        get => todayRainCounter;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            todayRainCounter = value;
        }
    }

    /// <summary>
    /// The accumulated amount of yesterday’s rain in mm.
    /// </summary>
    public double? YesterdayRainCounter
    {
        get => yesterdayRainCounter;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            yesterdayRainCounter = value;
        }
    }
}
