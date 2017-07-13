using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Server
    {
        public string ServerCode { get; set; }
        public byte Type { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }
        public bool? IsHeadQuarter { get; set; }
        public bool? IsActive { get; set; }
        public string Poscode { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
    }
}
