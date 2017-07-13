using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalCommodityType
    {
        public string CommodityTypeCode { get; set; }
        public string ServiceCode { get; set; }
        public double? FreightCoefficient { get; set; }
        public string InternationalFreightRuleCode { get; set; }

        public virtual CommodityType CommodityTypeCodeNavigation { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
