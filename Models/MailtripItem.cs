using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailtripItem
    {
        public string ItemCode { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailtripType { get; set; }
        public string ServiceCode { get; set; }
        public string ExtendServiceCode { get; set; }
        public string Year { get; set; }
        public string MailtripNumber { get; set; }
        public byte? Status { get; set; }
        public int? Sheet { get; set; }
        public int? IndexNumber { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
