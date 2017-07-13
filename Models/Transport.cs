using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Transport
    {
        public Transport()
        {
            MailtripTransport = new HashSet<MailtripTransport>();
        }

        public string TransportCode { get; set; }
        public string TransportGroup { get; set; }
        public double? TotalLoad { get; set; }
        public byte? Status { get; set; }
        public string Poscode { get; set; }
        public string StartYear { get; set; }
        public string EndYear { get; set; }
        public int? Partner { get; set; }

        public virtual ICollection<MailtripTransport> MailtripTransport { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
        public virtual TransportGroup TransportGroupNavigation { get; set; }
    }
}
