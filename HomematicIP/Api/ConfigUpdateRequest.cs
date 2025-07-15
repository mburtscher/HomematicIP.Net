namespace HomematicIP.Api;

public class ConfigUpdateRequest : PluginMessage<ConfigUpdateRequestBody>
{
}

public class ConfigUpdateRequestBody
{
    public string? LanguageCode { get; set; }
    public Dictionary<string, string?>? Properties { get; set; }
}
