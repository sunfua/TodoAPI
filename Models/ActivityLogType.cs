using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ActivityLogType
    {
        public ActivityLogType()
        {
            ActivityLog = new HashSet<ActivityLog>();
        }

        public int ActivityLogTypeId { get; set; }
        public string ActionKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }

        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
    }
}
