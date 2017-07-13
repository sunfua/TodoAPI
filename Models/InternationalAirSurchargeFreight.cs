using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalAirSurchargeFreight
    {
        public string InternationalAirSurchargeFreightCode { get; set; }
        public string ContinentCode { get; set; }
        public string ItemTypeCode { get; set; }
        public double? FromWeight { get; set; }
        public double? ToWeight { get; set; }
        public double? Freight { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public byte? CalculationMethod { get; set; }
        public string ServiceCode { get; set; }

        public virtual Continent ContinentCodeNavigation { get; set; }
        public virtual ItemType ItemTypeCodeNavigation { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
