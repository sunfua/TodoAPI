using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpReportTargetProperties
    {
        public RpReportTargetProperties()
        {
            RpReportTargetPropertyValues = new HashSet<RpReportTargetPropertyValues>();
        }

        public string ReportTargetCode { get; set; }
        public string ReportTargetPropertyCode { get; set; }
        public string ReportTargetPropertyName { get; set; }

        public virtual ICollection<RpReportTargetPropertyValues> RpReportTargetPropertyValues { get; set; }
        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}
