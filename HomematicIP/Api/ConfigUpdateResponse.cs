using HomematicIP.Domain;

namespace HomematicIP.Api;

public class ConfigUpdateResponse : PluginMessage<ConfigUpdateResponseBody>
{
}

public class ConfigUpdateResponseBody
{
    public ConfigUpdateResponseStatus Status { get; set; } = ConfigUpdateResponseStatus.APPLIED;
    public string? Message { get; set; }
}
