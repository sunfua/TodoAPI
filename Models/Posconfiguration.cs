using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Posconfiguration
    {
        public string Poscode { get; set; }
        public string ConfigCode { get; set; }
        public string ConfigValue { get; set; }

        public virtual Configuration ConfigCodeNavigation { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
