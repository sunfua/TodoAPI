using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CommuneFreightRegion
    {
        public string CommuneCode { get; set; }
        public string ServiceCode { get; set; }
        public string FreightRegionCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }

        public virtual Commune CommuneCodeNavigation { get; set; }
        public virtual FreightRegion FreightRegion { get; set; }
    }
}
