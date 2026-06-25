using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated type of presence modes. Used by plugin devices supporting the PresenceMode feature.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PresenceType
{
    AWAY,
    DEFAULT,
    HOME,
    NORMAL,
    VACATION,
}
