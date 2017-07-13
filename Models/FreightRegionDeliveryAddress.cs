using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class FreightRegionDeliveryAddress
    {
        public FreightRegionDeliveryAddress()
        {
            CommuneFreightRegionDeliveryAddress = new HashSet<CommuneFreightRegionDeliveryAddress>();
            DistrictFreightRegionDeliveryAddress = new HashSet<DistrictFreightRegionDeliveryAddress>();
        }

        public string FreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string FreightRegionName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CommuneFreightRegionDeliveryAddress> CommuneFreightRegionDeliveryAddress { get; set; }
        public virtual ICollection<DistrictFreightRegionDeliveryAddress> DistrictFreightRegionDeliveryAddress { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
