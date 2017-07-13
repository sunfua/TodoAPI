using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DetailProvinceFreight
    {
        public string FromProvinceCode { get; set; }
        public string ToProvinceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightStepCode { get; set; }
        public double? Freight { get; set; }

        public virtual DomesticFreightStep DomesticFreightStep { get; set; }
        public virtual ProvinceInterconnect ProvinceInterconnect { get; set; }
    }
}
