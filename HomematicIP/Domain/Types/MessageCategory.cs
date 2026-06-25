using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Category of a user message created by a plugin to be shown in the Homematic IP smartphone app. Used by the app to show the message with applicable color and icon.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MessageCategory
{
    ERROR,
    INFO,
    WARN,
}