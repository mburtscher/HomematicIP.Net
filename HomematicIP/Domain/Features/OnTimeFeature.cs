namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the time for which a plugin device shall remain switched on. Intended to be included in a control request to automatically turn off the device after the desired time.
/// </summary>
public class OnTimeFeature : FeatureBase
{
    private double? onTime;

    /// <summary>
    /// Desired time in seconds for which the device shall remain switched on.
    /// </summary>
    public double? OnTime
    {
        get => onTime;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            onTime = value;
        }
    }
}
