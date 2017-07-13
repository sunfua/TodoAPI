using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PosprintConfiguration
    {
        public string PrintedMatterCode { get; set; }
        public string ObjectName { get; set; }
        public string Poscode { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
        public virtual PrintConfiguration PrintConfiguration { get; set; }
    }
}
