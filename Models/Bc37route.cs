using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bc37route
    {
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string AcceptedPoscode { get; set; }
        public byte? Type { get; set; }
    }
}
