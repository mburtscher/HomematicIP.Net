using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated type of shading directions. Used by plugin devices supporting the ShutterDirection feature.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ShadingDirection
{
    DARKER,
    LIGHTER,
}

