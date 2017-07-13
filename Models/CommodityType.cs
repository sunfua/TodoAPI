using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CommodityType
    {
        public CommodityType()
        {
            DomesticCommodityType = new HashSet<DomesticCommodityType>();
            InternationalCommodityType = new HashSet<InternationalCommodityType>();
            ItemCommodityType = new HashSet<ItemCommodityType>();
            ServiceCommodityType = new HashSet<ServiceCommodityType>();
        }

        public string CommodityTypeCode { get; set; }
        public string CommodityTypeName { get; set; }
        public bool IsCompact { get; set; }
        public double? FreightCoefficient { get; set; }
        public byte? FreightType { get; set; }
        public byte? OrderIndex { get; set; }
        public string ServiceCode { get; set; }

        public virtual ICollection<DomesticCommodityType> DomesticCommodityType { get; set; }
        public virtual ICollection<InternationalCommodityType> InternationalCommodityType { get; set; }
        public virtual ICollection<ItemCommodityType> ItemCommodityType { get; set; }
        public virtual ICollection<ServiceCommodityType> ServiceCommodityType { get; set; }
    }
}
