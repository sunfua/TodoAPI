using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailRoutePos
    {
        public string MailRouteCode { get; set; }
        public string FromPoscode { get; set; }
        public string OnMailRoutePoscode { get; set; }
        public byte? Posorder { get; set; }
        public string MailRouteScheduleCode { get; set; }
        public bool Type { get; set; }
        public DateTime? IncomingTime { get; set; }
        public DateTime? OutgoingTime { get; set; }

        public virtual Pos OnMailRoutePoscodeNavigation { get; set; }
    }
}
