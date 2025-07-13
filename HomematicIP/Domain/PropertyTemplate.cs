using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomematicIP.Domain
{
    public class PropertyTemplate
    {
        public PropertyType DataType { get; set; } = PropertyType.STRING;
        public string FriendlyName { get; set; } = string.Empty;
        public string? CurrentValue { get; set; }
        public string? DefaultValue { get; set; }
        public string? Description { get; set; }
        public string? GroupId { get; set; }
        public int? Maximum { get; set; }
        public int? MaximumLength { get; set; }
        public int? Minimum { get; set; }
        public int? MinimumLength { get; set; }
        public int? Order { get; set; }
        public string? Pattern { get; set; }
        public bool? Required { get; set; }
        public List<string>? Values { get; set; }
    }
}
