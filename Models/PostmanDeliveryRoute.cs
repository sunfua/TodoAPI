using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PostmanDeliveryRoute
    {
        public string DelieveryRouteCode { get; set; }
        public string FromPoscode { get; set; }
        public string PostmanCode { get; set; }

        public virtual DeliveryRoute DeliveryRoute { get; set; }
        public virtual User User { get; set; }
    }
}
