namespace HomematicIP.Api;

public class ConfigTemplateRequest : PluginMessage<ConfigTemplateRequestBody>
{
}

public class ConfigTemplateRequestBody
{
    public string? LanguageCode { get; set; }
}
