using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CustomerGroup
    {
        public string CustomerGroupCode { get; set; }
        public string CustomerGroupName { get; set; }
        public string CustomerGroupContent { get; set; }
        public string DeliveryRequirement { get; set; }
    }
}
