using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ShiftHandoverMailtripTransport
    {
        public string Poscode { get; set; }
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string CounterCode { get; set; }
        public int TransportNumber { get; set; }
        public string FromPoscode { get; set; }
        public string TransportDate { get; set; }
        public string TransportCode { get; set; }
        public byte Status { get; set; }

        public virtual MailtripTransport MailtripTransport { get; set; }
        public virtual ShiftHandover ShiftHandover { get; set; }
    }
}
