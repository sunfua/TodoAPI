using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ValueAddedServiceItemUnUse
    {
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string ItemCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Vasusing Vasusing { get; set; }
    }
}
