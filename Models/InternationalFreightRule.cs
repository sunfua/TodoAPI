using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightRule
    {
        public InternationalFreightRule()
        {
            InternationalAirSurchargeFreight = new HashSet<InternationalAirSurchargeFreight>();
            InternationalCommodityType = new HashSet<InternationalCommodityType>();
            InternationalCountryFreight = new HashSet<InternationalCountryFreight>();
            InternationalFarRegionFreightStep = new HashSet<InternationalFarRegionFreightStep>();
            InternationalFreight = new HashSet<InternationalFreight>();
            InternationalFreightObject = new HashSet<InternationalFreightObject>();
            InternationalFreightRegion = new HashSet<InternationalFreightRegion>();
            InternationalFreightRuleItemTypeUsing = new HashSet<InternationalFreightRuleItemTypeUsing>();
            InternationalValueAddedServiceCountryFreight = new HashSet<InternationalValueAddedServiceCountryFreight>();
            InternationalValueAddedServiceFreightPerItem = new HashSet<InternationalValueAddedServiceFreightPerItem>();
            InternationalValueAddedServiceFreightPerTotalItem = new HashSet<InternationalValueAddedServiceFreightPerTotalItem>();
            InternationalValueAddedServiceFreightPerTotalWeight = new HashSet<InternationalValueAddedServiceFreightPerTotalWeight>();
        }

        public string InternationalFreightRuleCode { get; set; }
        public DateTime ValueDate { get; set; }
        public string RuleNo { get; set; }
        public string ServiceCode { get; set; }
        public byte? CalculationMethod { get; set; }
        public string MainFreightStoreProcedure { get; set; }
        public string ValueAddedServiceFreightStoreProcedure { get; set; }
        public string MainFreightFormula { get; set; }
        public string ValueAddedServiceFreightFormula { get; set; }
        public bool? HasVat { get; set; }
        public double? Vatpercent { get; set; }
        public byte? CommodityCalculationMethod { get; set; }
        public string ExchangeType { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public string ProvinceCode { get; set; }
        public string CustomerCode { get; set; }
        public int? FarRegionFreightType { get; set; }
        public double? FarRegionCoefficient { get; set; }
        public int? BatchCalculateMethod { get; set; }

        public virtual ICollection<InternationalAirSurchargeFreight> InternationalAirSurchargeFreight { get; set; }
        public virtual ICollection<InternationalCommodityType> InternationalCommodityType { get; set; }
        public virtual ICollection<InternationalCountryFreight> InternationalCountryFreight { get; set; }
        public virtual ICollection<InternationalFarRegionFreightStep> InternationalFarRegionFreightStep { get; set; }
        public virtual ICollection<InternationalFreight> InternationalFreight { get; set; }
        public virtual ICollection<InternationalFreightObject> InternationalFreightObject { get; set; }
        public virtual ICollection<InternationalFreightRegion> InternationalFreightRegion { get; set; }
        public virtual ICollection<InternationalFreightRuleItemTypeUsing> InternationalFreightRuleItemTypeUsing { get; set; }
        public virtual ICollection<InternationalValueAddedServiceCountryFreight> InternationalValueAddedServiceCountryFreight { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerItem> InternationalValueAddedServiceFreightPerItem { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerTotalItem> InternationalValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerTotalWeight> InternationalValueAddedServiceFreightPerTotalWeight { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
