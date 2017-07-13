using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TraceItem
    {
        public int TraceIndex { get; set; }
        public string ItemCode { get; set; }
        public string Poscode { get; set; }
        public byte? Status { get; set; }
        public DateTime? TraceDate { get; set; }
        public string StatusDesc { get; set; }
        public string Note { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
