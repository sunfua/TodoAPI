using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticSurchangeValueAddedServicePercent
    {
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? FuelSurchangePercent { get; set; }
        public DateTime ValueDate { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
        public virtual Vasusing Vasusing { get; set; }
    }
}
