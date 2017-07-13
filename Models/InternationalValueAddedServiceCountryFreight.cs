using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceCountryFreight
    {
        public string InternationalValueAddedServiceCountryFreightCode { get; set; }
        public string InternationalValueAddedServiceFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string CountryCode { get; set; }
        public double? Freight { get; set; }
        public string ValueAddedServiceCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual ValueAddedService ValueAddedServiceCodeNavigation { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
        public virtual InternationalValueAddedServiceFreightStep InternationalValueAddedServiceFreightStep { get; set; }
    }
}
