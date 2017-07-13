using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class BatchPos
    {
        public string BatchCode { get; set; }
        public string Poscode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
    }
}
