using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightPerTotalWeight
    {
        public string InternationalValueAddedServiceFreightPerTotalWeightCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string InternationalValueAddedServiceFreightStepCode { get; set; }
        public double? Freight { get; set; }

        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
        public virtual InternationalValueAddedServiceFreightStep InternationalValueAddedServiceFreightStep { get; set; }
    }
}
