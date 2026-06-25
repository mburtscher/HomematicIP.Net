namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the rain sensor of a plugin device.
/// </summary>
public class RainingFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether it is currently raining.
    /// </summary>
    public bool? Raining { get; set; }
}
