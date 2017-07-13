using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpReportTargets
    {
        public RpReportTargets()
        {
            RpAcceptanceDetailReport = new HashSet<RpAcceptanceDetailReport>();
            RpAcceptanceReports = new HashSet<RpAcceptanceReports>();
            RpAcceptanceReportsForOther = new HashSet<RpAcceptanceReportsForOther>();
            RpCustomerAcceptanceReports = new HashSet<RpCustomerAcceptanceReports>();
            RpCustomerAcceptanceReportsForOther = new HashSet<RpCustomerAcceptanceReportsForOther>();
            RpDeliveryReports = new HashSet<RpDeliveryReports>();
            RpProcessingReports = new HashSet<RpProcessingReports>();
            RpReportTargetProperties = new HashSet<RpReportTargetProperties>();
            RpTargetValueChanges = new HashSet<RpTargetValueChanges>();
            RpTransportReports = new HashSet<RpTransportReports>();
        }

        public string ReportTargetCode { get; set; }
        public string ReportTargetCatalogCode { get; set; }
        public string ReportTargetName { get; set; }
        public string StoreProcedureName { get; set; }
        public bool? IsChecked { get; set; }

        public virtual ICollection<RpAcceptanceDetailReport> RpAcceptanceDetailReport { get; set; }
        public virtual ICollection<RpAcceptanceReports> RpAcceptanceReports { get; set; }
        public virtual ICollection<RpAcceptanceReportsForOther> RpAcceptanceReportsForOther { get; set; }
        public virtual ICollection<RpCustomerAcceptanceReports> RpCustomerAcceptanceReports { get; set; }
        public virtual ICollection<RpCustomerAcceptanceReportsForOther> RpCustomerAcceptanceReportsForOther { get; set; }
        public virtual ICollection<RpDeliveryReports> RpDeliveryReports { get; set; }
        public virtual ICollection<RpProcessingReports> RpProcessingReports { get; set; }
        public virtual ICollection<RpReportTargetProperties> RpReportTargetProperties { get; set; }
        public virtual ICollection<RpTargetValueChanges> RpTargetValueChanges { get; set; }
        public virtual ICollection<RpTransportReports> RpTransportReports { get; set; }
        public virtual RpReportTargetCatalog ReportTargetCatalogCodeNavigation { get; set; }
        public virtual RpObjectsFillReportsData StoreProcedureNameNavigation { get; set; }
    }
}
