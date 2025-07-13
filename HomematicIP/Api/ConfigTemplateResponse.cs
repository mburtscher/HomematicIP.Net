using HomematicIP.Domain;

namespace HomematicIP.Api;

public class ConfigTemplateResponseBody
{
    public Dictionary<string, GroupTemplate>? Groups { get; set; }
    public Dictionary<string, PropertyTemplate> Properties { get; set; } = new Dictionary<string, PropertyTemplate>();
}

public class ConfigTemplateResponse : PluginMessage<ConfigTemplateResponseBody>
{
}
