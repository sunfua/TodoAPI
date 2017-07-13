using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightStepDeliveryAddress
    {
        public DomesticFreightStepDeliveryAddress()
        {
            DetailRegionFreightDeliveryAddress = new HashSet<DetailRegionFreightDeliveryAddress>();
        }

        public string DomesticFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double? FromWeight { get; set; }
        public double? ToWeight { get; set; }
        public double? FreightStep { get; set; }
        public byte? CalculationMethod { get; set; }

        public virtual ICollection<DetailRegionFreightDeliveryAddress> DetailRegionFreightDeliveryAddress { get; set; }
    }
}
