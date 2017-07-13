using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Driver
    {
        public Driver()
        {
            MailtripTransport = new HashSet<MailtripTransport>();
        }

        public string DriverCode { get; set; }
        public string DriverName { get; set; }
        public string Poscode { get; set; }
        public bool? IsEcort { get; set; }

        public virtual ICollection<MailtripTransport> MailtripTransport { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
