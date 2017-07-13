using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeliveryOther
    {
        public string DeliveryTargetCode { get; set; }
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public string DeliveryPoscode { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string PostmanCode { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryRouteName { get; set; }
        public string PostmanName { get; set; }
        public double? Value { get; set; }
        public string DeliveryMachine { get; set; }
        public string InputingUser { get; set; }
        public DateTime? InputDate { get; set; }
        public bool? TransferStatus { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
