using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Exchange
    {
        public Exchange()
        {
            ExchangeRate = new HashSet<ExchangeRate>();
            InternationalCompensateRule = new HashSet<InternationalCompensateRule>();
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            SenderInternationalCompensate = new HashSet<SenderInternationalCompensate>();
        }

        public string ExchangeCode { get; set; }
        public string ExchangeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ExchangeRate> ExchangeRate { get; set; }
        public virtual ICollection<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<SenderInternationalCompensate> SenderInternationalCompensate { get; set; }
    }
}
