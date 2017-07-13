using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PosfreightRegion
    {
        public string FreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string Poscode { get; set; }
        public string DomesticFreightRuleCode { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
        public virtual FreightRegion FreightRegion { get; set; }
    }
}
