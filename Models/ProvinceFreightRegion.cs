using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ProvinceFreightRegion
    {
        public string FreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string ProvinceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }

        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual FreightRegion FreightRegion { get; set; }
    }
}
