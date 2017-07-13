using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MessageTypeLastCall
    {
        public string Poscode { get; set; }
        public DateTime? LastCall { get; set; }
        public string MessageTypeName { get; set; }
    }
}
