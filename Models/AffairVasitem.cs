using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class AffairVasitem
    {
        public int AffairIndex { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string ItemCode { get; set; }
        public double? Freight { get; set; }
        public string PhaseCode { get; set; }
        public DateTime? AddedDate { get; set; }
        public double? FreightVat { get; set; }
        public string Poscode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public double? OriginalFreight { get; set; }
        public double? OriginalFreightVat { get; set; }
        public double? SubFreight { get; set; }
        public double? OriginalSubFreightVat { get; set; }
        public double? OriginalSubFreight { get; set; }
        public double? SubFreightVat { get; set; }
    }
}
