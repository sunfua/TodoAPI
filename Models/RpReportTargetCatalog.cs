using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpReportTargetCatalog
    {
        public RpReportTargetCatalog()
        {
            RpReportTargets = new HashSet<RpReportTargets>();
        }

        public string ReportTargetCatalogCode { get; set; }
        public string ReportTargetCatalogName { get; set; }
        public string ParentTargetCatalogCode { get; set; }

        public virtual ICollection<RpReportTargets> RpReportTargets { get; set; }
        public virtual RpReportTargetCatalog ParentTargetCatalogCodeNavigation { get; set; }
        public virtual ICollection<RpReportTargetCatalog> InverseParentTargetCatalogCodeNavigation { get; set; }
    }
}
