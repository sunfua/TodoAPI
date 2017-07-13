using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailRouteType
    {
        public MailRouteType()
        {
            MailRoute = new HashSet<MailRoute>();
        }

        public string MailRouteTypeCode { get; set; }
        public string MailRouteTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MailRoute> MailRoute { get; set; }
    }
}
