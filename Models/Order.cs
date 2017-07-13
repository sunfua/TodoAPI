using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Order
    {
        public string OrderCode { get; set; }
        public string Poscode { get; set; }
        public string CustomerCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? MainFreight { get; set; }
        public double? Discount { get; set; }
        public double? Abatement { get; set; }
        public double? TotalFreight { get; set; }
        public string Content { get; set; }
        public byte? Status { get; set; }

        public virtual Customer CustomerCodeNavigation { get; set; }
    }
}
