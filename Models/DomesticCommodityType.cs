using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticCommodityType
    {
        public string CommodityTypeCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double? FreightCoefficient { get; set; }

        public virtual CommodityType CommodityTypeCodeNavigation { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
