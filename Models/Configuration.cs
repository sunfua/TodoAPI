using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Configuration
    {
        public Configuration()
        {
            Posconfiguration = new HashSet<Posconfiguration>();
            ServiceConfiguration = new HashSet<ServiceConfiguration>();
            ServicePosconfiguration = new HashSet<ServicePosconfiguration>();
        }

        public string ConfigCode { get; set; }
        public string ConfigValue { get; set; }
        public string ConfigName { get; set; }

        public virtual ICollection<Posconfiguration> Posconfiguration { get; set; }
        public virtual ICollection<ServiceConfiguration> ServiceConfiguration { get; set; }
        public virtual ICollection<ServicePosconfiguration> ServicePosconfiguration { get; set; }
    }
}
