using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class SlpDeliveryReport
    {
        public string ItemCode { get; set; }
        public string DeliveryPoscode { get; set; }
        public int DeliveryType { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string PostmanCode { get; set; }
        public string ServiceCode { get; set; }
        public int? Range { get; set; }
        public string ItemTypeCode { get; set; }
        public bool? Cod { get; set; }
        public bool? HoaToc { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public DateTime? InputDate { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ReportDate { get; set; }
    }
}
