using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class AffairHistory
    {
        public int AffairHistoryId { get; set; }
        public int AffairIndex { get; set; }
        public string ItemCode { get; set; }
        public string HistoryContent { get; set; }
        public string HistoryCreator { get; set; }
        public string HistoryCreatedPos { get; set; }
        public DateTime HistoryCreatedDate { get; set; }
        public string BatchCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
