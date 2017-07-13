using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransitFreight
    {
        public string InternationalMailFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string CountryCode { get; set; }
        public string TransportTypeCode { get; set; }
        public double? HandlingRate { get; set; }
        public double? TransitRate { get; set; }
        public double? FreightPerFraction { get; set; }
        public string ExchangeRateCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual TransportType TransportTypeCodeNavigation { get; set; }
        public virtual InternationalMailFreightRule InternationalMailFreightRule { get; set; }
    }
}
