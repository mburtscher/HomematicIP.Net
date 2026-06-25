using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Behavior type of a user message created by a plugin to be shown in the Homematic IP smartphone app. Used by app to enable the user to dismiss or acknowledge the message, or to prevent the user from dismissing it.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BehaviorType
{
    /// <summary>
    /// Users may acknowledge and thereby dismiss the user message in the Homematic IP smartphone app. The plugin will receive an acknowledgement event with AckType OK when the message is acknowledged.
    /// </summary>
    ACKNOWLEDGEABLE_BY_OK,

    /// <summary>
    /// Users may acknowledge the user message by selecting YES or NO in the Homematic IP smartphone app. The plugin will receive an acknowledgement event with AckType YES or NO when the message is acknowledged. The plugin may then dismiss the user message by sending a delete user message request.
    /// </summary>
    ACKNOWLEDGEABLE_BY_YES_NO,

    /// <summary>
    /// Users may dismiss the user message in the Homematic IP smartphone app. The plugin will not receive an acknowledgement event when the message is dismissed.
    /// </summary>
    DISMISSIBLE,

    /// <summary>
    /// Users may not dismiss the user message in the Homematic IP smartphone app.
    /// </summary>
    NOT_DISMISSIBLE,
}