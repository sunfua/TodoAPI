﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Batch
    {
        public string BatchCode { get; set; }
        public string Poscode { get; set; }
        public string CustomerCode { get; set; }
        public string OrderCode { get; set; }
        public double? MainFreight { get; set; }
        public double? Discount { get; set; }
        public double? Abatement { get; set; }
        public double? TotalFreight { get; set; }
        public bool? InvoiceAttached { get; set; }
        public bool? OtherAttached { get; set; }
        public string OtherAttachedInfor { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
