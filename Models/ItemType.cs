using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemType
    {
        public ItemType()
        {
            DeductionDetail = new HashSet<DeductionDetail>();
            DomesticFreightRuleItemTypeUsing = new HashSet<DomesticFreightRuleItemTypeUsing>();
            DomesticFreightStep = new HashSet<DomesticFreightStep>();
            InternationalAirSurchargeFreight = new HashSet<InternationalAirSurchargeFreight>();
            InternationalFreightRuleItemTypeUsing = new HashSet<InternationalFreightRuleItemTypeUsing>();
            InternationalFreightStep = new HashSet<InternationalFreightStep>();
            Item = new HashSet<Item>();
            ServiceItemType = new HashSet<ServiceItemType>();
        }

        public string ItemTypeCode { get; set; }
        public string ItemTypeName { get; set; }
        public string Description { get; set; }
        public int? OrderIndex { get; set; }
        public byte? Type { get; set; }

        public virtual ICollection<DeductionDetail> DeductionDetail { get; set; }
        public virtual ICollection<DomesticFreightRuleItemTypeUsing> DomesticFreightRuleItemTypeUsing { get; set; }
        public virtual ICollection<DomesticFreightStep> DomesticFreightStep { get; set; }
        public virtual ICollection<InternationalAirSurchargeFreight> InternationalAirSurchargeFreight { get; set; }
        public virtual ICollection<InternationalFreightRuleItemTypeUsing> InternationalFreightRuleItemTypeUsing { get; set; }
        public virtual ICollection<InternationalFreightStep> InternationalFreightStep { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<ServiceItemType> ServiceItemType { get; set; }
    }
}
