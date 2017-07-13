using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightPropertyValue
    {
        public int InternationalFreightPropertyValueId { get; set; }
        public string InternationalFreightPropertyCode { get; set; }
        public string Value { get; set; }
        public int? InterntationalFreightObjectFreightId { get; set; }

        public virtual InternationalFreightProperty InternationalFreightPropertyCodeNavigation { get; set; }
        public virtual InternationalFreightObjectFreight InterntationalFreightObjectFreight { get; set; }
    }
}
