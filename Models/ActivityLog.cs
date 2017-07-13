using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ActivityLog
    {
        public int ActivityLogId { get; set; }
        public int ActivityLogTypeId { get; set; }
        public string Username { get; set; }
        public string Poscode { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual ActivityLogType ActivityLogType { get; set; }
        public virtual User User { get; set; }
    }
}
