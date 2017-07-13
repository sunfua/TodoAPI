using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CommunicationConfig
    {
        public string ConfigKey { get; set; }
        public string ConfigValue { get; set; }
        public string Description { get; set; }
    }
}
