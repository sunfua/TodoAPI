using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFarRegion
    {
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string DistrictCode { get; set; }

        public virtual District DistrictCodeNavigation { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
