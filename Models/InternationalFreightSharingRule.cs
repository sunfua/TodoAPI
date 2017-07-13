using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightSharingRule
    {
        public InternationalFreightSharingRule()
        {
            InternationalFreightSharing = new HashSet<InternationalFreightSharing>();
        }

        public string ServiceCode { get; set; }
        public string InternationalFreightSharingCode { get; set; }
        public string RuleNumber { get; set; }
        public DateTime ValueDate { get; set; }

        public virtual ICollection<InternationalFreightSharing> InternationalFreightSharing { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
