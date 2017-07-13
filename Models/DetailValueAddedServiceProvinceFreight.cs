using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DetailValueAddedServiceProvinceFreight
    {
        public string FromProvinceCode { get; set; }
        public string ToProvinceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticValueAddedServiceFreightStepCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public double? Freight { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
        public virtual DomesticValueAddedServiceFreightStep DomesticValueAddedServiceFreightStep { get; set; }
    }
}
