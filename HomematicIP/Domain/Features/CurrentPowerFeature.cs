using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomematicIP.Domain.Features;

public class CurrentPowerFeature : FeatureBase
{
    public int? CurrentPower { get; set; }
}
