using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RevenueSharing
    {
        public string ServiceCode { get; set; }
        public string ItemCode { get; set; }
        public string Poscode { get; set; }
        public string PhaseCode { get; set; }
        public double? Revenue { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
        public virtual ServicePhase ServicePhase { get; set; }
    }
}
