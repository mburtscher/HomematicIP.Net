namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the sunshine duration measured by a plugin device.
/// </summary>
public class SunshineDurationFeature : FeatureBase
{
    private int? sunshineDuration;
    private int? todaySunshineDuration;
    private int? yesterdaySunshineDuration;

    /// <summary>
    /// The total accumulated duration of sunshine in h.
    /// </summary>
    public int? SunshineDuration
    {
        get => sunshineDuration;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            sunshineDuration = value;
        }
    }

    /// <summary>
    /// The accumulated duration of today’s sunshine in h.
    /// </summary>
    public int? TodaySunshineDuration
    {
        get => todaySunshineDuration;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            todaySunshineDuration = value;
        }
    }

    /// <summary>
    /// The accumulated duration of yesterday’s sunshine in h.
    /// </summary>
    public int? YesterdaySunshineDuration
    {
        get => yesterdaySunshineDuration;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            yesterdaySunshineDuration = value;
        }
    }
}
