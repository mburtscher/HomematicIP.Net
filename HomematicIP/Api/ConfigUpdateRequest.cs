namespace HomematicIP.Api;

public class ConfigUpdateRequest : PluginMessage<ConfigUpdateRequestBody>
{
}

public class ConfigUpdateRequestBody
{
    public string? LanguageCode { get; set; }
    public Dictionary<string, object?>? Properties { get; set; }
}
