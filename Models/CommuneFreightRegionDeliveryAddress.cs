using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CommuneFreightRegionDeliveryAddress
    {
        public string FreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string CommuneCode { get; set; }

        public virtual Commune CommuneCodeNavigation { get; set; }
        public virtual FreightRegionDeliveryAddress FreightRegionDeliveryAddress { get; set; }
    }
}
