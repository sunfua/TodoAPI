using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpProcessingReports
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public int TargetIndex { get; set; }
        public int? SoLuongDen { get; set; }
        public double? KhoiLuongDen { get; set; }
        public int? SoLuongDi { get; set; }
        public double? KhoiLuongDi { get; set; }
        public string UserName { get; set; }
        public string Machinename { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}
