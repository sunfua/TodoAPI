using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpTransportReports
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public int TargetIndex { get; set; }
        public int? SoLuongTuiDi { get; set; }
        public double? KhoiLuongTuiDi { get; set; }
        public int? SoLuongTuiDen { get; set; }
        public double? KhoiLuongTuiDen { get; set; }
        public string UserName { get; set; }
        public string Machinename { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}
