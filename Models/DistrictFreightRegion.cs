using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DistrictFreightRegion
    {
        public string FreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string DistrictCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }

        public virtual District DistrictCodeNavigation { get; set; }
        public virtual FreightRegion FreightRegion { get; set; }
    }
}
