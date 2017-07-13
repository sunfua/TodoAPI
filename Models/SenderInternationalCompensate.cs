using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class SenderInternationalCompensate
    {
        public string SenderInternationalCompensateCode { get; set; }
        public string InternationalCompensateRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public double? FromWeight { get; set; }
        public double? ToWeight { get; set; }
        public double? CompensateMoney { get; set; }
        public string ExchangeCode { get; set; }
        public byte? CalculationMethod { get; set; }
        public double? CompenasteStep { get; set; }
        public string CompensateCategoryCode { get; set; }
        public string ClaimTypeCode { get; set; }
        public string CompensatePoscode { get; set; }
        public string DeciderName { get; set; }
        public string InputDeciderName { get; set; }
        public DateTime? InputDecideDate { get; set; }
        public int? ClaimNumber { get; set; }
        public string RecevingClaimPoscode { get; set; }

        public virtual Exchange ExchangeCodeNavigation { get; set; }
        public virtual Claim Claim { get; set; }
        public virtual InternationalCompensateRule InternationalCompensateRule { get; set; }
    }
}
