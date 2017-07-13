using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightStep
    {
        public DomesticFreightStep()
        {
            DetailProvinceFreight = new HashSet<DetailProvinceFreight>();
            DetailRegionFreight = new HashSet<DetailRegionFreight>();
        }

        public string DomesticFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public double FromWeight { get; set; }
        public double ToWeight { get; set; }
        public string ItemTypeCode { get; set; }
        public double FreightStep { get; set; }
        public byte CalculationMethod { get; set; }
        public bool? IsBatch { get; set; }
        public double? InternalProvinceFreight { get; set; }
        public byte? TransportType { get; set; }

        public virtual ICollection<DetailProvinceFreight> DetailProvinceFreight { get; set; }
        public virtual ICollection<DetailRegionFreight> DetailRegionFreight { get; set; }
        public virtual ItemType ItemTypeCodeNavigation { get; set; }
    }
}
