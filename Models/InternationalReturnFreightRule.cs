using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalReturnFreightRule
    {
        public InternationalReturnFreightRule()
        {
            InternationalReturnFreight = new HashSet<InternationalReturnFreight>();
        }

        public string ServiceCode { get; set; }
        public string InternationalFreightSharingCode { get; set; }
        public string RuleNumber { get; set; }
        public DateTime ValueDate { get; set; }

        public virtual ICollection<InternationalReturnFreight> InternationalReturnFreight { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
