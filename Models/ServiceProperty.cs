using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceProperty
    {
        public string ServiceCode { get; set; }
        public string PropertyCode { get; set; }

        public virtual Property PropertyCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
