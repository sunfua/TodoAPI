using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightPercentMainFreight
    {
        public string InternationalValueAddedServiceFreightPercentMainFreightCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? PercentMainFreight { get; set; }
        public string InternationalFreightRuleCode { get; set; }
    }
}
