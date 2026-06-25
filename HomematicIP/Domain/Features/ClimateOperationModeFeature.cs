using HomematicIP.Domain.Types;

namespace HomematicIP.Domain.Features;

/// <summary>
/// Feature representing the climate operation mode. Used mainly by AC.
/// </summary>
public class ClimateOperationModeFeature : FeatureBase
{
    /// <summary>
    /// The operation mode of the device.
    /// </summary>
    public ClimateOperationType? ClimateOperationMode { get; set; }
}
