using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailtripTransportPostBagLog
    {
        public string MailtripTransportPostBagLogCode { get; set; }
        public int PostBagIndex { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailtripType { get; set; }
        public string ServiceCode { get; set; }
        public string Year { get; set; }
        public string MailTripNumber { get; set; }
        public int Status { get; set; }
        public int Bc37index { get; set; }
        public string Bc37fromPoscode { get; set; }
        public string Bc37date { get; set; }
        public string Bc37toPoscode { get; set; }
        public string TransportTypeCode { get; set; }
        public int? Bc37order { get; set; }
        public string ConfirmUser { get; set; }
        public string ConfirmPoscode { get; set; }
        public string CreateUser { get; set; }
        public string CreatePoscode { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public DateTime? LogDate { get; set; }
        public string LogCreator { get; set; }
        public string LogContent { get; set; }
        public byte? LogAction { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
