using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceSupplying
    {
        public string CommuneCode { get; set; }
        public string Poscode { get; set; }

        public virtual Commune CommuneCodeNavigation { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
