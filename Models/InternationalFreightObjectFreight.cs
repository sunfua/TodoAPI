using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightObjectFreight
    {
        public InternationalFreightObjectFreight()
        {
            InternationalFreightPropertyValue = new HashSet<InternationalFreightPropertyValue>();
        }

        public int InterntationalFreightObjectFreightId { get; set; }
        public string InternationalFreightObjectCode { get; set; }
        public int? RowIndex { get; set; }
        public double? Freight { get; set; }

        public virtual ICollection<InternationalFreightPropertyValue> InternationalFreightPropertyValue { get; set; }
        public virtual InternationalFreightObject InternationalFreightObjectCodeNavigation { get; set; }
    }
}
