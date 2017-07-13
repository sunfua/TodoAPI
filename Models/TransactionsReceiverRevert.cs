using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionsReceiverRevert
    {
        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public string TransactionsReceiverCode { get; set; }
        public string TransactionsReceiverRevertCode { get; set; }
        public string TransactionsReceiverRevertChannel { get; set; }
        public DateTime? RevertDate { get; set; }
        public string Reason { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual TransactionsReceiver TransactionsReceiver { get; set; }
    }
}
