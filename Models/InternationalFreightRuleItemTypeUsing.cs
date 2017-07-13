using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightRuleItemTypeUsing
    {
        public string ServiceCode { get; set; }
        public string InternationalFreightRuleCode { get; set; }
        public string ItemTypeCode { get; set; }
        public byte? CalculateMethod { get; set; }

        public virtual ItemType ItemTypeCodeNavigation { get; set; }
        public virtual InternationalFreightRule InternationalFreightRule { get; set; }
    }
}
