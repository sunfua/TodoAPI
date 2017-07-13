using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ExchangeRelationship
    {
        public string FromPoscode { get; set; }
        public string OnMailRoutePoscode { get; set; }
        public string MailRouteCode { get; set; }
        public string ExchangePoscode { get; set; }
        public string MailRouteScheduleCode { get; set; }
        public bool? Type { get; set; }
        public string ServiceCode { get; set; }
        public byte? ResetType { get; set; }
        public bool? IsDiscreteMailRoute { get; set; }
        public byte? Status { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
