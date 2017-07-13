using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InlandFreight
    {
        public string InternationalMailFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string CountryCode { get; set; }
        public double? InlandRate { get; set; }
        public string ExchangeRateCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual InternationalMailFreightRule InternationalMailFreightRule { get; set; }
    }
}
