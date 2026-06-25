using System.Text.Json.Serialization;

namespace HomematicIP.Domain.Types;

/// <summary>
/// Enumerated data type of a plugin configuration property defined in a property template.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PropertyType
{
    /// <summary>
    /// Type for boolean properties.
    /// </summary>
    BOOLEAN,

    /// <summary>
    /// Type for property with a predefined set of values. In the property template, use the field 'values' to provide the set of possible values.
    /// </summary>
    ENUM,

    /// <summary>
    /// Type for integer properties. In the property template, use the fields 'minimum' and 'maximum' to define constraints.
    /// </summary>
    INTEGER,

    /// <summary>
    /// Type for floating point number properties. In the property template, use the fields 'minimum' and 'maximum' to define constraints.
    /// </summary>
    NUMBER,

    /// <summary>
    /// Type for password properties. Will be displayed obscured.
    /// </summary>
    PASSWORD,

    /// <summary>
    /// Type for QR code properties. In the property template, use the field 'currentValue' for the text used to generate the QR code.
    /// </summary>
    QRCODE,

    /// <summary>
    /// Type for string properties that cannot be modified by user. In the property template, use the field 'currentValue' for the read-only text.
    /// </summary>
    READONLY,

    /// <summary>
    /// Type for string properties. In the property template, use the fields 'minimumLength', 'maximumLength' and 'pattern' to define constraints.
    /// </summary>
    STRING,

    /// <summary>
    /// Type for string properties with autocompletion. In the property template, use the field 'values' for a list of possible values the user may select while typing.
    /// </summary>
    TYPEAHEAD,

    /// <summary>
    /// Type for for weblink properties. In the property template, use the field 'currentValue' for the link and the field 'defaultValue' for additional info text.
    /// </summary>
    WEBLINK
};
