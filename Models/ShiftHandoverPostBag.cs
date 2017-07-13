using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ShiftHandoverPostBag
    {
        public int HandoverIndex { get; set; }
        public string CounterCode { get; set; }
        public string ShiftCode { get; set; }
        public string Poscode { get; set; }
        public int PostBagIndex { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailTripType { get; set; }
        public string ServiceCode { get; set; }
        public string Year { get; set; }
        public string MailTripNumber { get; set; }
        public byte Status { get; set; }
        public int? ShiftCodeOlder { get; set; }
        public byte? IsOpen { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ShiftHandover ShiftHandover { get; set; }
        public virtual PostBag PostBag { get; set; }
    }
}
