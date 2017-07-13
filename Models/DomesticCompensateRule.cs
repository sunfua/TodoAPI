using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticCompensateRule
    {
        public DomesticCompensateRule()
        {
            ReceiverDomesticCompensate = new HashSet<ReceiverDomesticCompensate>();
            SenderDomesticCompensate = new HashSet<SenderDomesticCompensate>();
        }

        public string DomesitcCompensateRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public DateTime ValueDate { get; set; }
        public string RuleNumber { get; set; }

        public virtual ICollection<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual ICollection<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
