using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticValueAddedServiceFreightPerItem
    {
        public string DomesticValueAddedServiceFreightPerItemCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? FreightPerItem { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double? MinimumFreight { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
