namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the switch state of a plugin device.
/// </summary>
public class SwitchStateFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device is switched on or off.
    /// </summary>
    public bool? On { get; set; }
}
