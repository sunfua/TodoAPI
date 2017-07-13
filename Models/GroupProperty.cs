using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class GroupProperty
    {
        public GroupProperty()
        {
            Property = new HashSet<Property>();
        }

        public string GroupPropertyCode { get; set; }
        public string GroupPropertyName { get; set; }
        public string Description { get; set; }
        public int? OrderIndex { get; set; }

        public virtual ICollection<Property> Property { get; set; }
    }
}
