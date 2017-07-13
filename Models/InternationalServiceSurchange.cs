using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalServiceSurchange
    {
        public string InternationalServiceSurchangeCode { get; set; }
        public string ServiceCode { get; set; }
        public DateTime ValueDate { get; set; }
        public double? InternationalMainFreightPercent { get; set; }
        public double? InternationalAirSurchangeFreightPercent { get; set; }
        public string Notes { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double? ValueAddedServiceFreightPercent { get; set; }

        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
