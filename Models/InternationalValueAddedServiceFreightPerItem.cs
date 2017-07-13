using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightPerItem
    {
        public string InternationalValueAddedServiceFreightPerItemCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? FreightPerItem { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double? MinimumFreight { get; set; }

        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
