namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the vehicle range of a plugin device.
/// </summary>
public class VehicleRangeFeature : FeatureBase
{
    private double? travelRange;

    /// <summary>
    /// The remaining travel range of the vehicle in km.
    /// </summary>
    public double? TravelRange
    {
        get => travelRange;
        set
        {
            if (value.HasValue)
            {
                ArgumentOutOfRangeException.ThrowIfLessThan(value.Value, 0);
            }
            
            travelRange = value;
        }
    }
}
