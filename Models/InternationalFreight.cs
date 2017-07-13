using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreight
    {
        public string InternationalFreightCode { get; set; }
        public string InternationalFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string InternationalFreightRegionCode { get; set; }
        public double? Freight { get; set; }

        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
        public virtual InternationalFreightRegion InternationalFreightRegion { get; set; }
        public virtual InternationalFreightStep InternationalFreightStep { get; set; }
    }
}
