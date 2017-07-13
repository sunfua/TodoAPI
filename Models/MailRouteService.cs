using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailRouteService
    {
        public string ServiceCode { get; set; }
        public string MailRouteCode { get; set; }
        public string FromPoscode { get; set; }

        public virtual Service ServiceCodeNavigation { get; set; }
        public virtual MailRoute MailRoute { get; set; }
    }
}
