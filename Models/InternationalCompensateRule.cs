using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalCompensateRule
    {
        public InternationalCompensateRule()
        {
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            SenderInternationalCompensate = new HashSet<SenderInternationalCompensate>();
        }

        public string InternationalCompensateRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public DateTime ValueDate { get; set; }
        public string RuleNumber { get; set; }
        public double? InventoryMoney { get; set; }
        public string ExchangeCode { get; set; }
        public string CompensateCategoryCode { get; set; }
        public string ClaimTypeCode { get; set; }
        public string CompensatePoscode { get; set; }
        public string DeciderName { get; set; }
        public string InputDeciderName { get; set; }
        public DateTime? InputDecideDate { get; set; }

        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<SenderInternationalCompensate> SenderInternationalCompensate { get; set; }
        public virtual ClaimType ClaimTypeCodeNavigation { get; set; }
        public virtual CompensateCategory CompensateCategoryCodeNavigation { get; set; }
        public virtual Pos CompensatePoscodeNavigation { get; set; }
        public virtual Exchange ExchangeCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
