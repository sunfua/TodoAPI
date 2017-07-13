using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CompensateCategory
    {
        public CompensateCategory()
        {
            InternationalCompensateRule = new HashSet<InternationalCompensateRule>();
            ReceiverDomesticCompensate = new HashSet<ReceiverDomesticCompensate>();
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            SenderDomesticCompensate = new HashSet<SenderDomesticCompensate>();
        }

        public string CompensateCategoryCode { get; set; }
        public string CompensateCategoryName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual ICollection<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
    }
}
