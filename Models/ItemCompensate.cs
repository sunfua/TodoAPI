using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemCompensate
    {
        public string ItemCode { get; set; }
        public double? CompensateMoney { get; set; }
        public DateTime? CompensateDate { get; set; }
        public string CompensateReason { get; set; }
        public string CompensateUsername { get; set; }
        public string CompensatePoscode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
