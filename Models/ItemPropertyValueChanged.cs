using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemPropertyValueChanged
    {
        public string ItemCode { get; set; }
        public int ChangeIndex { get; set; }
        public int HandoverIndex { get; set; }
        public string ChangePoscode { get; set; }
        public string PropertyCode { get; set; }
        public string Value { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ItemChanged ItemChanged { get; set; }
    }
}
