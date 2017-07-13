using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalTransitFreightRule
    {
        public InternationalTransitFreightRule()
        {
            InternationalTransitFreight = new HashSet<InternationalTransitFreight>();
        }

        public string ServiceCode { get; set; }
        public string InternationalFreightSharingCode { get; set; }
        public string RuleNumber { get; set; }
        public DateTime ValueDate { get; set; }

        public virtual ICollection<InternationalTransitFreight> InternationalTransitFreight { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
