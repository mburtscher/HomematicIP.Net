using System.Text.Json.Serialization;

namespace HomematicIP.Api;


public class PluginMessage<TBody> : PluginMessage
    where TBody : new()
{
    public TBody Body { get; set; } = new TBody();
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ConfigTemplateRequest), typeDiscriminator: "CONFIG_TEMPLATE_REQUEST")]
[JsonDerivedType(typeof(ConfigTemplateResponse), typeDiscriminator: "CONFIG_TEMPLATE_RESPONSE")]
[JsonDerivedType(typeof(ConfigUpdateRequest), typeDiscriminator: "CONFIG_UPDATE_REQUEST")]
[JsonDerivedType(typeof(ConfigUpdateResponse), typeDiscriminator: "CONFIG_UPDATE_RESPONSE")]
[JsonDerivedType(typeof(DiscoverRequest), typeDiscriminator: "DISCOVER_REQUEST")]
[JsonDerivedType(typeof(DiscoverResponse), typeDiscriminator: "DISCOVER_RESPONSE")]
[JsonDerivedType(typeof(InclusionEvent), typeDiscriminator: "INCLUSION_EVENT")]
[JsonDerivedType(typeof(PluginStateRequest), typeDiscriminator: "PLUGIN_STATE_REQUEST")]
[JsonDerivedType(typeof(PluginStateResponse), typeDiscriminator: "PLUGIN_STATE_RESPONSE")]
[JsonDerivedType(typeof(StatusRequest), typeDiscriminator: "STATUS_REQUEST")]
[JsonDerivedType(typeof(StatusResponse), typeDiscriminator: "STATUS_RESPONSE")]
public class PluginMessage
{
    public Guid? Id { get; set; }
    public string? PluginId { get; set; }
}
