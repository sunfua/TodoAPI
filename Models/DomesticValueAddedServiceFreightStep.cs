using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticValueAddedServiceFreightStep
    {
        public DomesticValueAddedServiceFreightStep()
        {
            DetailValueAddedServiceProvinceFreight = new HashSet<DetailValueAddedServiceProvinceFreight>();
            DetailValueAddedServiceRegionFreight = new HashSet<DetailValueAddedServiceRegionFreight>();
            DomesticValueAddedServiceFreightTotalWeight = new HashSet<DomesticValueAddedServiceFreightTotalWeight>();
        }

        public string DomesticValueAddedServiceFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double FromWeight { get; set; }
        public double ToWeight { get; set; }
        public string ItemTypeCode { get; set; }
        public double FreightStep { get; set; }
        public byte CalculationMethod { get; set; }
        public bool? IsBatch { get; set; }
        public double? InternalProvinceFreight { get; set; }
        public string ValueAddedServiceCode { get; set; }

        public virtual ICollection<DetailValueAddedServiceProvinceFreight> DetailValueAddedServiceProvinceFreight { get; set; }
        public virtual ICollection<DetailValueAddedServiceRegionFreight> DetailValueAddedServiceRegionFreight { get; set; }
        public virtual ICollection<DomesticValueAddedServiceFreightTotalWeight> DomesticValueAddedServiceFreightTotalWeight { get; set; }
    }
}
