using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Phase
    {
        public Phase()
        {
            PrintedMatterPhase = new HashSet<PrintedMatterPhase>();
            ServicePhase = new HashSet<ServicePhase>();
            ValueAddedServicePhase = new HashSet<ValueAddedServicePhase>();
        }

        public string PhaseCode { get; set; }
        public string PhaseName { get; set; }
        public string Description { get; set; }
        public string ParentPhaseCode { get; set; }

        public virtual ICollection<PrintedMatterPhase> PrintedMatterPhase { get; set; }
        public virtual ICollection<ServicePhase> ServicePhase { get; set; }
        public virtual ICollection<ValueAddedServicePhase> ValueAddedServicePhase { get; set; }
        public virtual Phase ParentPhaseCodeNavigation { get; set; }
        public virtual ICollection<Phase> InverseParentPhaseCodeNavigation { get; set; }
    }
}
