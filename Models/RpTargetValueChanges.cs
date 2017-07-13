using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpTargetValueChanges
    {
        public string InsertedDate { get; set; }
        public string Poscode { get; set; }
        public string ShiftCode { get; set; }
        public string ReportTargetCode { get; set; }
        public int ChangedIndex { get; set; }
        public int TargetIndex { get; set; }
        public DateTime ChangedDate { get; set; }
        public string ChangedUser { get; set; }
        public string PropertyName { get; set; }
        public double OldValue { get; set; }
        public double NewValue { get; set; }
        public byte Type { get; set; }

        public virtual RpReportTargets ReportTargetCodeNavigation { get; set; }
    }
}
