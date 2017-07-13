using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            DetailItem = new HashSet<DetailItem>();
            InlandFreight = new HashSet<InlandFreight>();
            InternationalCountryRegion = new HashSet<InternationalCountryRegion>();
            InternationalFreightSharing = new HashSet<InternationalFreightSharing>();
            InternationalValueAddedServiceCountryFreight = new HashSet<InternationalValueAddedServiceCountryFreight>();
            Item = new HashSet<Item>();
            LimitWeight = new HashSet<LimitWeight>();
            Oe = new HashSet<Oe>();
            TransitFreight = new HashSet<TransitFreight>();
        }

        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ContinentCode { get; set; }
        public bool? IsPrintedCn23 { get; set; }
        public bool? IsPostalParcels { get; set; }

        public virtual ICollection<DetailItem> DetailItem { get; set; }
        public virtual ICollection<InlandFreight> InlandFreight { get; set; }
        public virtual ICollection<InternationalCountryRegion> InternationalCountryRegion { get; set; }
        public virtual ICollection<InternationalFreightSharing> InternationalFreightSharing { get; set; }
        public virtual ICollection<InternationalValueAddedServiceCountryFreight> InternationalValueAddedServiceCountryFreight { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<LimitWeight> LimitWeight { get; set; }
        public virtual ICollection<Oe> Oe { get; set; }
        public virtual ICollection<TransitFreight> TransitFreight { get; set; }
        public virtual Continent ContinentCodeNavigation { get; set; }
    }
}
