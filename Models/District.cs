using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class District
    {
        public District()
        {
            Commune = new HashSet<Commune>();
            DistrictFreightRegion = new HashSet<DistrictFreightRegion>();
            DistrictFreightRegionDeliveryAddress = new HashSet<DistrictFreightRegionDeliveryAddress>();
            DomesticFarRegion = new HashSet<DomesticFarRegion>();
            Item = new HashSet<Item>();
        }

        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public string Description { get; set; }
        public string ProvinceCode { get; set; }

        public virtual ICollection<Commune> Commune { get; set; }
        public virtual ICollection<DistrictFreightRegion> DistrictFreightRegion { get; set; }
        public virtual ICollection<DistrictFreightRegionDeliveryAddress> DistrictFreightRegionDeliveryAddress { get; set; }
        public virtual ICollection<DomesticFarRegion> DomesticFarRegion { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
    }
}
