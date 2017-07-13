using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Dispatch
    {
        public int PostBagIndex { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailTripType { get; set; }
        public string ServiceCode { get; set; }
        public string Year { get; set; }
        public string MailTripNumber { get; set; }
        public string ItemCode { get; set; }
        public byte? Status { get; set; }
        public int? IndexNumber { get; set; }
        public int? Sheet { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string CounterCode { get; set; }
        public string ShiftCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string PostmanCode { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Counter Counter { get; set; }
        public virtual Shift Shift { get; set; }
        public virtual PostBag PostBag { get; set; }
    }
}
