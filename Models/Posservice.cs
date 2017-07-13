using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Posservice
    {
        public string Poscode { get; set; }
        public string ServiceCode { get; set; }
        public double? DomesticMaximumWeight { get; set; }
        public double? InternationMaximumWeight { get; set; }
        public double? DomesticMinimumFreight { get; set; }
        public double? InternationMinimumWeight { get; set; }
        public bool? IsRunning { get; set; }
        public bool? AllowsQuick { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
