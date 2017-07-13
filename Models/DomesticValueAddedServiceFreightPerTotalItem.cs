using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticValueAddedServiceFreightPerTotalItem
    {
        public string DomesticValueAddedServiceFreightPerTotalItemCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double? FromNumberOfItem { get; set; }
        public double? ToNumberOfItem { get; set; }
        public double? Freight { get; set; }
        public double? MinimumFreight { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
    }
}
