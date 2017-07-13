using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightPerTotalItem
    {
        public string InternationalValueAddedServiceFreightPerTotalItemCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double? FromNumberOfItem { get; set; }
        public double? ToNumberOfItem { get; set; }
        public double? FreightStep { get; set; }
        public double? Freight { get; set; }
        public double? MinimumFreight { get; set; }

        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
    }
}
