using HomematicIP.Domain.Types;

namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the shutter direction of a plugin device.
/// </summary>
public class ShutterDirectionFeature : FeatureBase
{
    /// <summary>
    /// The direction in which the shutter moved last.
    /// </summary>
    public ShadingDirection? ShutterDirection { get; set; }
}
