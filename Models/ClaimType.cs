using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ClaimType
    {
        public ClaimType()
        {
            Claim = new HashSet<Claim>();
            InternationalCompensateRule = new HashSet<InternationalCompensateRule>();
            ReceiverDomesticCompensate = new HashSet<ReceiverDomesticCompensate>();
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            SenderDomesticCompensate = new HashSet<SenderDomesticCompensate>();
        }

        public string ClaimTypeCode { get; set; }
        public string ClaimTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual ICollection<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
    }
}
