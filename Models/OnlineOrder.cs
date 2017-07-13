﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class OnlineOrder
    {
        public OnlineOrder()
        {
            OnlineBatch = new HashSet<OnlineBatch>();
        }

        public string OrderCode { get; set; }
        public string Poscode { get; set; }
        public string CustomerCode { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? MainFreight { get; set; }
        public double? Discount { get; set; }
        public double? Abatement { get; set; }
        public double? TotalFreight { get; set; }

        public virtual ICollection<OnlineBatch> OnlineBatch { get; set; }
        public virtual Customer CustomerCodeNavigation { get; set; }
    }
}
