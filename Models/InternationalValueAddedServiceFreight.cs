using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreight
    {
        public string InternationalValueAddedServiceFreightCode { get; set; }
        public string InternationalValueAddedServiceFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string InternationalFreightRegionCode { get; set; }
        public double? Freight { get; set; }
        public string ValueAddedServiceCode { get; set; }
    }
}
