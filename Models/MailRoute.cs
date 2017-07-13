using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailRoute
    {
        public MailRoute()
        {
            MailRouteSchedule = new HashSet<MailRouteSchedule>();
            MailRouteService = new HashSet<MailRouteService>();
        }

        public string MailRouteCode { get; set; }
        public string TransportTypeCode { get; set; }
        public string MailRouteName { get; set; }
        public string Description { get; set; }
        public string MailRouteTypeCode { get; set; }
        public string FromPoscode { get; set; }
        public byte? MailTripFrequencePerDay { get; set; }

        public virtual ICollection<MailRouteSchedule> MailRouteSchedule { get; set; }
        public virtual ICollection<MailRouteService> MailRouteService { get; set; }
        public virtual Pos FromPoscodeNavigation { get; set; }
        public virtual MailRouteType MailRouteTypeCodeNavigation { get; set; }
        public virtual TransportType TransportTypeCodeNavigation { get; set; }
    }
}
