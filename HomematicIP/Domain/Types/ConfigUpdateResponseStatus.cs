using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Describes the result or intermediate status of a plugin configuration update that was triggered by a HCUweb user by updating the plugin configuration and saving the changes.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ConfigUpdateResponseStatus
{
    /// <summary>
    /// The plugin configuration update was applied successfully.
    /// </summary>
    APPLIED,

    /// <summary>
    /// The plugin configuration update could not be applied.
    /// </summary>
    FAILED,

    /// <summary>
    /// The plugin configuration update is still pending, e.g. because applying it takes time or requires user interaction.
    /// </summary>
    PENDING,
}