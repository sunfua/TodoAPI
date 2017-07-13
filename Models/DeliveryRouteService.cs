using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeliveryRouteService
    {
        public DeliveryRouteService()
        {
            DeliveryScoping = new HashSet<DeliveryScoping>();
        }

        public string DeliveryRouteCode { get; set; }
        public string FromPoscode { get; set; }
        public string ServiceCode { get; set; }

        public virtual ICollection<DeliveryScoping> DeliveryScoping { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
