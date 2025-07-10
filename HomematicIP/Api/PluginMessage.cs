using System.Text.Json.Serialization;

namespace HomematicIP.Api;


public class PluginMessage<TBody> : PluginMessage
    where TBody : new()
{
    public TBody Body { get; set; } = new TBody();
}

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(DiscoverRequest), typeDiscriminator: "DISCOVER_REQUEST")]
[JsonDerivedType(typeof(ConfigTemplateRequest), typeDiscriminator: "CONFIG_TEMPLATE_REQUEST")]
[JsonDerivedType(typeof(StatusRequest), typeDiscriminator: "STATUS_REQUEST")]
[JsonDerivedType(typeof(DiscoverResponse), typeDiscriminator: "DISCOVER_RESPONSE")]
[JsonDerivedType(typeof(PluginStateResponse), typeDiscriminator: "PLUGIN_STATE_RESPONSE")]
[JsonDerivedType(typeof(ConfigTemplateResponse), typeDiscriminator: "CONFIG_TEMPLATE_RESPONSE")]
[JsonDerivedType(typeof(StatusResponse), typeDiscriminator: "STATUS_RESPONSE")]
[JsonDerivedType(typeof(InclusionEvent), typeDiscriminator: "INCLUSION_EVENT")]
public class PluginMessage
{
    public Guid? Id { get; set; }
    public string? PluginId { get; set; }
}
