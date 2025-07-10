using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HomematicIP.Domain.Features
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
    [JsonDerivedType(typeof(CurrentPowerFeature), typeDiscriminator: "currentPower")]
    [JsonDerivedType(typeof(BatteryStateFeature), typeDiscriminator: "batteryState")]
    public class FeatureBase
    {
    }
}
