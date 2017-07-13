using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeliveryRoute
    {
        public DeliveryRoute()
        {
            PostmanDeliveryRoute = new HashSet<PostmanDeliveryRoute>();
        }

        public string DelieveryRouteCode { get; set; }
        public string FromPoscode { get; set; }
        public string DeliverRouteName { get; set; }
        public string Description { get; set; }
        public string DeliveryRouteName { get; set; }

        public virtual ICollection<PostmanDeliveryRoute> PostmanDeliveryRoute { get; set; }
        public virtual Pos FromPoscodeNavigation { get; set; }
    }
}
