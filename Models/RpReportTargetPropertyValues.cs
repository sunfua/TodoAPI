using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpReportTargetPropertyValues
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public string ReportTargetPropertyCode { get; set; }
        public double Value { get; set; }
        public string UserName { get; set; }
        public string Machinename { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual RpReportTargetProperties ReportTarget { get; set; }
    }
}
