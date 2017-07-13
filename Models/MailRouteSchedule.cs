using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailRouteSchedule
    {
        public MailRouteSchedule()
        {
            MailtripTransport = new HashSet<MailtripTransport>();
        }

        public string MailRouteScheduleCode { get; set; }
        public string MailRouteCode { get; set; }
        public string FromPoscode { get; set; }
        public string Description { get; set; }
        public string MailRouteScheduleName { get; set; }

        public virtual ICollection<MailtripTransport> MailtripTransport { get; set; }
        public virtual MailRoute MailRoute { get; set; }
    }
}
