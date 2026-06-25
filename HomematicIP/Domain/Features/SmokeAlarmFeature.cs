namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing smoke alarm function of a plugin device.
/// </summary>
public class SmokeAlarmFeature : FeatureBase
{
    /// <summary>
    /// Flag to indicate whether the device is currently detecting smoke.
    /// </summary>
    public bool? SmokeAlarm { get; set; }
}
