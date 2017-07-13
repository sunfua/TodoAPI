using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Vasproperty
    {
        public Vasproperty()
        {
            ItemVaspropertyValue = new HashSet<ItemVaspropertyValue>();
        }

        public string PropertyCode { get; set; }
        public string PropertyName { get; set; }
        public string DataType { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string Description { get; set; }
        public string Control { get; set; }
        public string ControlValue { get; set; }

        public virtual ICollection<ItemVaspropertyValue> ItemVaspropertyValue { get; set; }
        public virtual ValueAddedService ValueAddedServiceCodeNavigation { get; set; }
    }
}
