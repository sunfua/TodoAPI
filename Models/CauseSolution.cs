using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CauseSolution
    {
        public CauseSolution()
        {
            Delivery = new HashSet<Delivery>();
        }

        public string CauseCode { get; set; }
        public string SolutionCode { get; set; }

        public virtual ICollection<Delivery> Delivery { get; set; }
        public virtual Cause CauseCodeNavigation { get; set; }
        public virtual Solution SolutionCodeNavigation { get; set; }
    }
}
