﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightProperty
    {
        public DomesticFreightProperty()
        {
            DomesticFreightPropertyValue = new HashSet<DomesticFreightPropertyValue>();
        }

        public string DomesticFreightPropertyCode { get; set; }
        public string DomesticFreightPropertyName { get; set; }
        public string DomesticFreightObjectCode { get; set; }

        public virtual ICollection<DomesticFreightPropertyValue> DomesticFreightPropertyValue { get; set; }
        public virtual DomesticFreightObject DomesticFreightObjectCodeNavigation { get; set; }
    }
}
