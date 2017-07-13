using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightRegion
    {
        public InternationalFreightRegion()
        {
            InternationalCountryRegion = new HashSet<InternationalCountryRegion>();
            InternationalFreight = new HashSet<InternationalFreight>();
        }

        public string InternationalFreightRegionCode { get; set; }
        public string ServiceCode { get; set; }
        public string InternationalFreightRegionName { get; set; }
        public string InternationalFreightRuleCode { get; set; }

        public virtual ICollection<InternationalCountryRegion> InternationalCountryRegion { get; set; }
        public virtual ICollection<InternationalFreight> InternationalFreight { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
