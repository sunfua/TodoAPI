using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFarRegionCommune
    {
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public string CommuneCode { get; set; }

        public virtual Commune CommuneCodeNavigation { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
