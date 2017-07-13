using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticFreightRuleItemTypeUsing
    {
        public string ServiceCode { get; set; }
        public string DomesticFreightRuleCode { get; set; }
        public string ItemTypeCode { get; set; }
        public byte? CalculateMethod { get; set; }
        public byte? BatchCalculateMethod { get; set; }
        public bool? HasVat { get; set; }
        public bool? HasFuelSurchange { get; set; }
        public bool? HasCommodityFreight { get; set; }
        public int? FarRegionFreightType { get; set; }

        public virtual ItemType ItemTypeCodeNavigation { get; set; }
        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
