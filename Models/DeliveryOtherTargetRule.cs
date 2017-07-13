using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeliveryOtherTargetRule
    {
        public string DeliveryTargetCode { get; set; }
        public double MinimunValue { get; set; }
        public double MaximumValue { get; set; }

        public virtual DeliveryOtherTarget DeliveryTargetCodeNavigation { get; set; }
    }
}
