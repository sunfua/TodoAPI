using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightRuleLastUpdate
    {
        public string DomesticFreightRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
