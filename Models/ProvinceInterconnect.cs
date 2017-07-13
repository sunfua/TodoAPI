using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ProvinceInterconnect
    {
        public ProvinceInterconnect()
        {
            DetailProvinceFreight = new HashSet<DetailProvinceFreight>();
        }

        public string FromProvinceCode { get; set; }
        public string ToProvinceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public double? DomesticMainFreightPercent { get; set; }
        public double? DomesticAirSurchargeFreightPercent { get; set; }

        public virtual ICollection<DetailProvinceFreight> DetailProvinceFreight { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
