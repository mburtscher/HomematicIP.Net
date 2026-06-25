using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Acknowledgement type of a user message created by a plugin to be shown in the Homematic IP smartphone app.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AckType
{
    /// <summary>
    /// User acknowledged the message with NO. Applicable for user messages with BehaviorType 'ACKNOWLEDGEABLE_BY_YES_NO'.
    /// </summary>
    NO,

    /// <summary>
    /// User acknowledged the message with OK. Applicable for user messages with BehaviorType 'ACKNOWLEDGEABLE_BY_OK'.
    /// </summary>
    OK,

    /// <summary>
    /// User acknowledged the message with YES. Applicable for user messages with BehaviorType 'ACKNOWLEDGEABLE_BY_YES_NO'.
    /// </summary>
    YES,
}