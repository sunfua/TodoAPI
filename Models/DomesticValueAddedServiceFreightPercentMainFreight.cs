using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticValueAddedServiceFreightPercentMainFreight
    {
        public string DomesticValueAddedServiceFreightPercentMainFreightCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? PercentMainFreight { get; set; }
        public string DomesticFreightRuleCode { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
    }
}
