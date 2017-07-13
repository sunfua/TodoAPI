using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Commune
    {
        public Commune()
        {
            CommuneFreightRegion = new HashSet<CommuneFreightRegion>();
            CommuneFreightRegionDeliveryAddress = new HashSet<CommuneFreightRegionDeliveryAddress>();
            DeliveryScoping = new HashSet<DeliveryScoping>();
            DomesticFarRegionCommune = new HashSet<DomesticFarRegionCommune>();
            ServiceSupplying = new HashSet<ServiceSupplying>();
            Unit = new HashSet<Unit>();
        }

        public string CommuneCode { get; set; }
        public string CommuneName { get; set; }
        public string DistrictCode { get; set; }

        public virtual ICollection<CommuneFreightRegion> CommuneFreightRegion { get; set; }
        public virtual ICollection<CommuneFreightRegionDeliveryAddress> CommuneFreightRegionDeliveryAddress { get; set; }
        public virtual ICollection<DeliveryScoping> DeliveryScoping { get; set; }
        public virtual ICollection<DomesticFarRegionCommune> DomesticFarRegionCommune { get; set; }
        public virtual ICollection<ServiceSupplying> ServiceSupplying { get; set; }
        public virtual ICollection<Unit> Unit { get; set; }
        public virtual District DistrictCodeNavigation { get; set; }
    }
}
