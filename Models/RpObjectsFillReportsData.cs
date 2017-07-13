using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpObjectsFillReportsData
    {
        public RpObjectsFillReportsData()
        {
            RpObjectParameters = new HashSet<RpObjectParameters>();
            RpReportTargets = new HashSet<RpReportTargets>();
        }

        public string StoreProcedureName { get; set; }
        public int? ExceutedOrder { get; set; }

        public virtual ICollection<RpObjectParameters> RpObjectParameters { get; set; }
        public virtual ICollection<RpReportTargets> RpReportTargets { get; set; }
    }
}
