using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TargetCataloge
    {
        public TargetCataloge()
        {
            Targets = new HashSet<Targets>();
        }

        public string TargetCatalogeCode { get; set; }
        public string TargetCatalogeName { get; set; }
        public string TargetCatalogeParentCode { get; set; }

        public virtual ICollection<Targets> Targets { get; set; }
        public virtual TargetCataloge TargetCatalogeParentCodeNavigation { get; set; }
        public virtual ICollection<TargetCataloge> InverseTargetCatalogeParentCodeNavigation { get; set; }
    }
}
