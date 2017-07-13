using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionsCollectionDetail
    {
        public int TransactionsCollectionIndex { get; set; }
        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public int? TransactionsCollectionType { get; set; }
        public double? Codamount { get; set; }
        public double? Codpostage { get; set; }
        public int? CodpostagePerson { get; set; }
        public int? AffairIndex { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual TransactionsCollection TransactionsCollection { get; set; }
    }
}
