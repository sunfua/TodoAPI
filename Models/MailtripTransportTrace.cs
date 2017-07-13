using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailtripTransportTrace
    {
        public int MailtripTransportTraceIndex { get; set; }
        public string Poscode { get; set; }
        public DateTime TraceDate { get; set; }
        public string TraceDescription { get; set; }
        public string Status { get; set; }
        public string FromPoscode { get; set; }
        public string TransportDate { get; set; }
        public string TransportCode { get; set; }
        public int TransportNumber { get; set; }
        public byte? Direct { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual MailtripTransport MailtripTransport { get; set; }
    }
}
