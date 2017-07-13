using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemPropertyValue
    {
        public string ItemCode { get; set; }
        public string PropertyCode { get; set; }
        public string Value { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Property PropertyCodeNavigation { get; set; }
    }
}
