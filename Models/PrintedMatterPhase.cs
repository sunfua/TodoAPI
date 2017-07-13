using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PrintedMatterPhase
    {
        public string PrintedMatterCode { get; set; }
        public string PhaseCode { get; set; }

        public virtual Phase PhaseCodeNavigation { get; set; }
        public virtual PrintedMatter PrintedMatterCodeNavigation { get; set; }
    }
}
