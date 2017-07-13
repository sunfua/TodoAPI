using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalSurchangeValueAddedServicePercent
    {
        public string InternationalFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? FuelSurchangePercent { get; set; }
        public DateTime ValueDate { get; set; }
    }
}
