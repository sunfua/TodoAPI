using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DirectionRoute
    {
        public string OnMailRoutePoscode { get; set; }
        public string ExchangePoscode { get; set; }
        public string ServiceCode { get; set; }
        public string DestinationCode { get; set; }
    }
}
