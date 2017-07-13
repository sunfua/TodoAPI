using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightRule
    {
        public DomesticFreightRule()
        {
            DetailValueAddedServiceProvinceFreight = new HashSet<DetailValueAddedServiceProvinceFreight>();
            DetailValueAddedServiceRegionFreight = new HashSet<DetailValueAddedServiceRegionFreight>();
            DomesticCollectionFreight = new HashSet<DomesticCollectionFreight>();
            DomesticCommodityType = new HashSet<DomesticCommodityType>();
            DomesticFarRegion = new HashSet<DomesticFarRegion>();
            DomesticFarRegionCommune = new HashSet<DomesticFarRegionCommune>();
            DomesticFarRegionFreightStep = new HashSet<DomesticFarRegionFreightStep>();
            DomesticFreightObject = new HashSet<DomesticFreightObject>();
            DomesticFreightRuleItemTypeUsing = new HashSet<DomesticFreightRuleItemTypeUsing>();
            DomesticSurchangeValueAddedServicePercent = new HashSet<DomesticSurchangeValueAddedServicePercent>();
            DomesticValueAddedServiceFreightPercentMainFreight = new HashSet<DomesticValueAddedServiceFreightPercentMainFreight>();
            DomesticValueAddedServiceFreightPerItem = new HashSet<DomesticValueAddedServiceFreightPerItem>();
            DomesticValueAddedServiceFreightPerMoney = new HashSet<DomesticValueAddedServiceFreightPerMoney>();
            DomesticValueAddedServiceFreightPerStockDay = new HashSet<DomesticValueAddedServiceFreightPerStockDay>();
            DomesticValueAddedServiceFreightPerTotalItem = new HashSet<DomesticValueAddedServiceFreightPerTotalItem>();
            DomesticValueAddedServiceFreightPerTotalItemInBatch = new HashSet<DomesticValueAddedServiceFreightPerTotalItemInBatch>();
            DomesticValueAddedServiceFreightTotalWeight = new HashSet<DomesticValueAddedServiceFreightTotalWeight>();
            FreightRegion = new HashSet<FreightRegion>();
            FreightRegionDeliveryAddress = new HashSet<FreightRegionDeliveryAddress>();
            ProvinceInterconnect = new HashSet<ProvinceInterconnect>();
            RegionInterconnect = new HashSet<RegionInterconnect>();
        }

        public string DomesticFreightRuleCode { get; set; }
        public DateTime ValueDate { get; set; }
        public string RuleNo { get; set; }
        public string ServiceCode { get; set; }
        public double? CollectionFreight { get; set; }
        public double? CollectionFreightPercent { get; set; }
        public double? HeavyItemFactor { get; set; }
        public double? FragileItemFactor { get; set; }
        public double? OtherFactor { get; set; }
        public string MainFreightStoreProcedure { get; set; }
        public string ValueAddedServiceFreightStoreProcedure { get; set; }
        public string MainFreightFormula { get; set; }
        public string ValueAddedServiceFreightFormula { get; set; }
        public bool? HasVat { get; set; }
        public double? Vatpercent { get; set; }
        public string ProvinceCode { get; set; }
        public string CustomerCode { get; set; }
        public byte? CommodityCalculationMethod { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public double? FarRegionCoefficient { get; set; }
        public int? FarRegionFreightType { get; set; }
        public int? BatchCalculateMethod { get; set; }

        public virtual ICollection<DetailValueAddedServiceProvinceFreight> DetailValueAddedServiceProvinceFreight { get; set; }
        public virtual ICollection<DetailValueAddedServiceRegionFreight> DetailValueAddedServiceRegionFreight { get; set; }
        public virtual ICollection<DomesticCollectionFreight> DomesticCollectionFreight { get; set; }
        public virtual ICollection<DomesticCommodityType> DomesticCommodityType { get; set; }
        public virtual ICollection<DomesticFarRegion> DomesticFarRegion { get; set; }
        public virtual ICollection<DomesticFarRegionCommune> DomesticFarRegionCommune { get; set; }
        public virtual ICollection<DomesticFarRegionFreightStep> DomesticFarRegionFreightStep { get; set; }
        public virtual ICollection<DomesticFreightObject> DomesticFreightObject { get; set; }
        public virtual ICollection<DomesticFreightRuleItemTypeUsing> DomesticFreightRuleItemTypeUsing { get; set; }
        public virtual ICollection<DomesticSurchangeValueAddedServicePercent> DomesticSurchangeValueAddedServicePercent { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPercentMainFreight> DomesticValueAddedServiceFreightPercentMainFreight { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerItem> DomesticValueAddedServiceFreightPerItem { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerMoney> DomesticValueAddedServiceFreightPerMoney { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerStockDay> DomesticValueAddedServiceFreightPerStockDay { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerTotalItem> DomesticValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerTotalItemInBatch> DomesticValueAddedServiceFreightPerTotalItemInBatch { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightTotalWeight> DomesticValueAddedServiceFreightTotalWeight { get; set; }
        public virtual ICollection<FreightRegion> FreightRegion { get; set; }
        public virtual ICollection<FreightRegionDeliveryAddress> FreightRegionDeliveryAddress { get; set; }
        public virtual ICollection<ProvinceInterconnect> ProvinceInterconnect { get; set; }
        public virtual ICollection<RegionInterconnect> RegionInterconnect { get; set; }
    }
}
