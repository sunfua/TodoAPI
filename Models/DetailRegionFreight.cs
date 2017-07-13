using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DetailRegionFreight
    {
        public string FromFreightRegionCode { get; set; }
        public string ToFreightRegionCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightStepCode { get; set; }
        public double? Freight { get; set; }

        public virtual DomesticFreightStep DomesticFreightStep { get; set; }
        public virtual RegionInterconnect RegionInterconnect { get; set; }
    }
}
