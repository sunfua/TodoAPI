using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightObject
    {
        public InternationalFreightObject()
        {
            InternationalFreightObjectFreight = new HashSet<InternationalFreightObjectFreight>();
            InternationalFreightProperty = new HashSet<InternationalFreightProperty>();
        }

        public string InternationalFreightObjectCode { get; set; }
        public string InternationalFreightObjectName { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string Formula { get; set; }

        public virtual ICollection<InternationalFreightObjectFreight> InternationalFreightObjectFreight { get; set; }
        public virtual ICollection<InternationalFreightProperty> InternationalFreightProperty { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
