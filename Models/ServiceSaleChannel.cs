using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceSaleChannel
    {
        public string ServiceCode { get; set; }
        public string SaleChannelCode { get; set; }

        public virtual SaleChannel SaleChannelCodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
