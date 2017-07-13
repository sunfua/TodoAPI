using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalCountryRegion
    {
        public string CountryCode { get; set; }
        public string InternationalFreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual InternationalFreightRegion InternationalFreightRegion { get; set; }
    }
}
