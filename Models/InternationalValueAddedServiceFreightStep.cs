using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightStep
    {
        public InternationalValueAddedServiceFreightStep()
        {
            InternationalValueAddedServiceCountryFreight = new HashSet<InternationalValueAddedServiceCountryFreight>();
            InternationalValueAddedServiceFreightPerTotalWeight = new HashSet<InternationalValueAddedServiceFreightPerTotalWeight>();
        }

        public string InternationalValueAddedServiceFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double FromWeight { get; set; }
        public double ToWeight { get; set; }
        public string ItemTypeCode { get; set; }
        public double FreightStep { get; set; }
        public byte CalculationMethod { get; set; }
        public bool? IsBatch { get; set; }
        public string ValueAddedServiceCode { get; set; }

        public virtual ICollection<InternationalValueAddedServiceCountryFreight> InternationalValueAddedServiceCountryFreight { get; set; }
        public virtual ICollection<InternationalValueAddedServiceFreightPerTotalWeight> InternationalValueAddedServiceFreightPerTotalWeight { get; set; }
    }
}
