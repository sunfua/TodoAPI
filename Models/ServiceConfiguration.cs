using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceConfiguration
    {
        public string ServiceCode { get; set; }
        public string ConfigCode { get; set; }
        public string ConfigValue { get; set; }

        public virtual Configuration ConfigCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
