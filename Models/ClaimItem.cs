using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ClaimItem
    {
        public int ClaimNumber { get; set; }
        public string RecevingClaimPoscode { get; set; }
        public string ItemCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual Claim Claim { get; set; }
    }
}
