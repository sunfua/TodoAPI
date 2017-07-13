using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightPropertyValue
    {
        public int DomesticFreightPropertyValueId { get; set; }
        public string DomesticFreightPropertyCode { get; set; }
        public string Value { get; set; }
        public int? DomesticFreightObjectFreightId { get; set; }

        public virtual DomesticFreightObjectFreight DomesticFreightObjectFreight { get; set; }
        public virtual DomesticFreightProperty DomesticFreightPropertyCodeNavigation { get; set; }
    }
}
