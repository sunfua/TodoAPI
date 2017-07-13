using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ExchangeServiceHistory
    {
        public string UserName { get; set; }
        public string Apiname { get; set; }
        public DateTime? LastCall { get; set; }
    }
}
