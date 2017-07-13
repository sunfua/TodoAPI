using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceCommodityType
    {
        public ServiceCommodityType()
        {
            RangeCommodityType = new HashSet<RangeCommodityType>();
        }

        public string ServiceCode { get; set; }
        public string CommodityTypeCode { get; set; }

        public virtual ICollection<RangeCommodityType> RangeCommodityType { get; set; }
        public virtual CommodityType CommodityTypeCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
