namespace HomematicIP.Api;

public class ConfigTemplateResponseBody
{
    public Dictionary<string, object> Groups { get; set; } = new Dictionary<string, object>();
    public Dictionary<string, object> Properties { get; set; } = new Dictionary<string, object>();
}

public class ConfigTemplateResponse : PluginMessage<ConfigTemplateResponseBody>
{
}
