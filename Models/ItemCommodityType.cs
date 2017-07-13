using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemCommodityType
    {
        public string ItemCode { get; set; }
        public string CommodityTypeCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual CommodityType CommodityTypeCodeNavigation { get; set; }
        public virtual Item ItemCodeNavigation { get; set; }
    }
}
