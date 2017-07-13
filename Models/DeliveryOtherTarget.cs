using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeliveryOtherTarget
    {
        public string DeliveryTargetCode { get; set; }
        public string RecordNumber { get; set; }
        public string DeliveryTargetName { get; set; }
        public string ParentDeliveryTargetCode { get; set; }
        public string ServiceCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public int? Range { get; set; }
        public int? DeliveryType { get; set; }
        public int? UnitType { get; set; }
        public int? OrderIndex { get; set; }
        public bool? AllowInput { get; set; }
        public bool? Enabled { get; set; }

        public virtual DeliveryOtherTargetRule DeliveryOtherTargetRule { get; set; }
    }
}
