using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticValueAddedServiceFreightTotalWeight
    {
        public string DomesticValueAddedServiceFreightPerTotalWeightCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string DomesticValueAddedServiceFreightStepCode { get; set; }
        public double? Freight { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
        public virtual DomesticValueAddedServiceFreightStep DomesticValueAddedServiceFreightStep { get; set; }
    }
}
