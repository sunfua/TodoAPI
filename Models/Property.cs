using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Property
    {
        public Property()
        {
            ItemPropertyValue = new HashSet<ItemPropertyValue>();
            ServiceProperty = new HashSet<ServiceProperty>();
        }

        public string PropertyCode { get; set; }
        public string PropertyName { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string Control { get; set; }
        public string ControlValue { get; set; }
        public int? OrderIndex { get; set; }
        public string GroupPropertyCode { get; set; }

        public virtual ICollection<ItemPropertyValue> ItemPropertyValue { get; set; }
        public virtual ICollection<ServiceProperty> ServiceProperty { get; set; }
        public virtual GroupProperty GroupPropertyCodeNavigation { get; set; }
    }
}
