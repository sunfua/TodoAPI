using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightStep
    {
        public InternationalFreightStep()
        {
            InternationalFreight = new HashSet<InternationalFreight>();
        }

        public string InternationalFreightStepCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double FromWeight { get; set; }
        public double ToWeight { get; set; }
        public string ItemTypeCode { get; set; }
        public double FreightStep { get; set; }
        public byte CalculationMethod { get; set; }
        public bool? IsBatch { get; set; }
        public byte? TransportType { get; set; }

        public virtual ICollection<InternationalFreight> InternationalFreight { get; set; }
        public virtual ItemType ItemTypeCodeNavigation { get; set; }
    }
}
