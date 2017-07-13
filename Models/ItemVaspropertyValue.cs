using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemVaspropertyValue
    {
        public string ItemCode { get; set; }
        public string PropertyCode { get; set; }
        public string Value { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Vasproperty Vasproperty { get; set; }
    }
}
