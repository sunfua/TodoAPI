using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TraceTransactionsCollection
    {
        public int TraceIndex { get; set; }
        public string ItemCode { get; set; }
        public DateTime? TraceDate { get; set; }
        public int? Status { get; set; }
        public string TransactionsCollectionCode { get; set; }
        public string Poscode { get; set; }
        public string Note { get; set; }
        public string Channel { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual TransactionsCollection TransactionsCollection { get; set; }
    }
}
