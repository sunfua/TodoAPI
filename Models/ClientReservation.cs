using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ClientReservation
    {
        public Guid ClientReservationId { get; set; }
        public DateTime ReservationTime { get; set; }
        public string SessionId { get; set; }
    }
}
