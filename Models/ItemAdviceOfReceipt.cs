using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemAdviceOfReceipt
    {
        public string ItemCode { get; set; }
        public string AdviceOfReceiptCode { get; set; }
        public string CheckContentOnDeliveryCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public bool? TransferStatus { get; set; }
    }
}
