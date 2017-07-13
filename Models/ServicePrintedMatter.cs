using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServicePrintedMatter
    {
        public string ServiceCode { get; set; }
        public string PrintedMatterCode { get; set; }

        public virtual PrintedMatter PrintedMatterCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
