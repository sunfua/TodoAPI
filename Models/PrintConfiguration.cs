using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PrintConfiguration
    {
        public PrintConfiguration()
        {
            PosprintConfiguration = new HashSet<PosprintConfiguration>();
        }

        public string PrintedMatterCode { get; set; }
        public string ObjectName { get; set; }
        public string Description { get; set; }
        public double Y { get; set; }
        public double X { get; set; }

        public virtual ICollection<PosprintConfiguration> PosprintConfiguration { get; set; }
        public virtual PrintedMatter PrintedMatterCodeNavigation { get; set; }
    }
}
