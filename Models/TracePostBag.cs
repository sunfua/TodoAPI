using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TracePostBag
    {
        public int PostBagIndex { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailTripType { get; set; }
        public string ServiceCode { get; set; }
        public string Year { get; set; }
        public string MailTripNumber { get; set; }
        public string Poscode { get; set; }
        public byte? Status { get; set; }
        public string StatusDescription { get; set; }
        public DateTime? TraceDate { get; set; }
        public int TraceIndex { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual PostBag PostBag { get; set; }
    }
}
