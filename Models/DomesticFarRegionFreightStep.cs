using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFarRegionFreightStep
    {
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public double Freight { get; set; }
        public double FromWeight { get; set; }
        public double ToWeight { get; set; }
        public double FreightStep { get; set; }
        public byte CalculationMethod { get; set; }
        public string DomesticFarRegionFreightStepCode { get; set; }
        public string ItemTypeCode { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
