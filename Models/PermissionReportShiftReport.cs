using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PermissionReportShiftReport
    {
        public string ReportId { get; set; }
        public string ReportName { get; set; }
        public int? ReportOrder { get; set; }
        public string ReportDes { get; set; }
        public bool Enable { get; set; }
    }
}
