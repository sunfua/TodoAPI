using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailtripTransportBc37
    {
        public string Bc37date { get; set; }
        public int Bc37index { get; set; }
        public string Bc37fromPoscode { get; set; }
        public string Bc37toPoscode { get; set; }
        public string TransportTypeCode { get; set; }
        public int? Bc37order { get; set; }
        public string MailtripTransportFromPoscode { get; set; }
        public string TransportDate { get; set; }
        public string TransportCode { get; set; }
        public string ConfirmUser { get; set; }
        public string ConfirmPoscode { get; set; }
        public string CreateUser { get; set; }
        public string CreatePoscode { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public int TransportNumber { get; set; }
        public byte? Direct { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual MailtripTransport MailtripTransport { get; set; }
        public virtual Bc37 Bc37 { get; set; }
    }
}
