using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Sms
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string MessageContent { get; set; }
        public int? Status { get; set; }
        public int? MtId { get; set; }
        public DateTime? SendingTime { get; set; }
    }
}
