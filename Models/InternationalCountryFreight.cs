using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalCountryFreight
    {
        public string InternationalCountryFreightCode { get; set; }
        public string InternationalFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string CountryCode { get; set; }
        public double? Freight { get; set; }

        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
