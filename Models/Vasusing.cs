using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Vasusing
    {
        public Vasusing()
        {
            DomesticSurchangeValueAddedServicePercent = new HashSet<DomesticSurchangeValueAddedServicePercent>();
            DomesticValueAddedServiceFreightPercentMainFreight = new HashSet<DomesticValueAddedServiceFreightPercentMainFreight>();
            DomesticValueAddedServiceFreightPerMoney = new HashSet<DomesticValueAddedServiceFreightPerMoney>();
            DomesticValueAddedServiceFreightPerStockDay = new HashSet<DomesticValueAddedServiceFreightPerStockDay>();
            DomesticValueAddedServiceFreightPerTotalItem = new HashSet<DomesticValueAddedServiceFreightPerTotalItem>();
            DomesticValueAddedServiceFreightPerTotalItemInBatch = new HashSet<DomesticValueAddedServiceFreightPerTotalItemInBatch>();
            DomesticValueAddedServiceFreightTotalWeight = new HashSet<DomesticValueAddedServiceFreightTotalWeight>();
            InternationalValueAddedServiceFreightPerTotalItem = new HashSet<InternationalValueAddedServiceFreightPerTotalItem>();
            InternationalValueAddedServiceFreightPerTotalWeight = new HashSet<InternationalValueAddedServiceFreightPerTotalWeight>();
            ValueAddedServiceItem = new HashSet<ValueAddedServiceItem>();
            ValueAddedServiceItemUnUse = new HashSet<ValueAddedServiceItemUnUse>();
            ValueAddedServicePhase = new HashSet<ValueAddedServicePhase>();
        }

        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public byte? CalculationMethod { get; set; }
        public string DomesticExpression { get; set; }
        public string InternationalExpression { get; set; }

        public virtual ICollection<DomesticSurchangeValueAddedServicePercent> DomesticSurchangeValueAddedServicePercent { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPercentMainFreight> DomesticValueAddedServiceFreightPercentMainFreight { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerMoney> DomesticValueAddedServiceFreightPerMoney { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerStockDay> DomesticValueAddedServiceFreightPerStockDay { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerTotalItem> DomesticValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightPerTotalItemInBatch> DomesticValueAddedServiceFreightPerTotalItemInBatch { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightTotalWeight> DomesticValueAddedServiceFreightTotalWeight { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerTotalItem> InternationalValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerTotalWeight> InternationalValueAddedServiceFreightPerTotalWeight { get; set; }
        public virtual ICollection<ValueAddedServiceItem> ValueAddedServiceItem { get; set; }
        public virtual ICollection<ValueAddedServiceItemUnUse> ValueAddedServiceItemUnUse { get; set; }
        public virtual ICollection<ValueAddedServicePhase> ValueAddedServicePhase { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
        public virtual ValueAddedService ValueAddedServiceCodeNavigation { get; set; }
    }
}
