using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated type of the plugin state. Included in a PluginStateResponse sent by the plugin to the Home Control Unit.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PluginReadinessStatus
{
    /// <summary>
    /// The plugin has to be configured to work as intended. This status should be used to communicate to users that they have to configure the plugin via HCUweb.
    /// </summary>
    CONFIG_REQUIRED,

    /// <summary>
    /// The plugin could not be started, or any other unexpected error occurred. This status should be used to communicate to users that the plugin is not functioning as expected.
    /// </summary>
    ERROR,

    /// <summary>
    /// The plugin is up and running. This status should be used to communicate to users that the plugin is ready for usage, typically right after startup or after successfully applying a configuration update.
    /// </summary>
    READY,
};
