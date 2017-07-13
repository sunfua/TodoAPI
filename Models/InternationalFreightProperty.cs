using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightProperty
    {
        public InternationalFreightProperty()
        {
            InternationalFreightPropertyValue = new HashSet<InternationalFreightPropertyValue>();
        }

        public string InternationalFreightObjectCode { get; set; }
        public string InternationalFreightPropertyCode { get; set; }
        public string InternationalFreightPropertyName { get; set; }

        public virtual ICollection<InternationalFreightPropertyValue> InternationalFreightPropertyValue { get; set; }
        public virtual InternationalFreightObject InternationalFreightObjectCodeNavigation { get; set; }
    }
}
