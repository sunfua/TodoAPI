using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DetailRegionFreightDeliveryAddress
    {
        public string ToFreightRegionCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightStepCode { get; set; }
        public double? Freight { get; set; }

        public virtual DomesticFreightStepDeliveryAddress DomesticFreightStepDeliveryAddress { get; set; }
    }
}
