using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated type of climate operation modes. Used by plugin devices supporting the ClimateOperationMode feature.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ClimateOperationType
{
    AUTO,
    COOLING,
    HEATING,
}
