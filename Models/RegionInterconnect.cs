using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RegionInterconnect
    {
        public RegionInterconnect()
        {
            DetailRegionFreight = new HashSet<DetailRegionFreight>();
        }

        public string FromFreightRegionCode { get; set; }
        public string ToFreightRegionCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public double? DomesticMainFreightPercent { get; set; }
        public double? DomesticAirSurchargeFreightPercent { get; set; }

        public virtual ICollection<DetailRegionFreight> DetailRegionFreight { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
