using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalValueAddedServiceFreightPerTotalItemInBatch
    {
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public double? FromNumberOfItem { get; set; }
        public double? ToNumberOfItem { get; set; }
        public double? Freight { get; set; }
        public double? MinimumFreight { get; set; }
        public string InternationalValueAddedServiceFreightPerTotalItemInBatchCode { get; set; }
    }
}
