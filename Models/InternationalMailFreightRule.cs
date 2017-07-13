using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalMailFreightRule
    {
        public InternationalMailFreightRule()
        {
            InlandFreight = new HashSet<InlandFreight>();
            TransitFreight = new HashSet<TransitFreight>();
        }

        public string InternationalMailFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string RuleNumber { get; set; }
        public DateTime ValueDate { get; set; }
        public double? Lcaorate { get; set; }
        public double? Mrate { get; set; }
        public double? ItemRate { get; set; }

        public virtual ICollection<InlandFreight> InlandFreight { get; set; }
        public virtual ICollection<TransitFreight> TransitFreight { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
