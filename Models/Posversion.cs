using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Posversion
    {
        public string Poscode { get; set; }
        public string MachineName { get; set; }
        public string Bccpversion { get; set; }
        public string Bccpdbversion { get; set; }
        public string WindowsVersion { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
