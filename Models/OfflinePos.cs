using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class OfflinePos
    {
        public string OfflinePoscode { get; set; }
        public string OnlinePoscode { get; set; }

        public virtual Pos OfflinePoscodeNavigation { get; set; }
        public virtual Pos OnlinePoscodeNavigation { get; set; }
    }
}
