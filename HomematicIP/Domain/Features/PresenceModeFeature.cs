using HomematicIP.Domain.Types;

namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the presence mode of a plugin device.
/// </summary>
public class PresenceModeFeature : FeatureBase
{
    /// <summary>
    /// The currently active presence mode.
    /// </summary>
    public PresenceType? PresenceMode { get; set; }
}
