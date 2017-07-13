using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionsPaymentRevert
    {
        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public string TransactionsPaymentCode { get; set; }
        public string TransactionsPaymentRevertCode { get; set; }
        public string TransactionsPaymentRevertChannel { get; set; }
        public DateTime? RevertDate { get; set; }
        public string Reason { get; set; }
        public int? Staus { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual TransactionsPayment TransactionsPayment { get; set; }
    }
}
