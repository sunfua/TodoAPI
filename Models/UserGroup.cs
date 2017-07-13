using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class UserGroup
    {
        public string GroupCode { get; set; }
        public string Username { get; set; }
        public string Poscode { get; set; }

        public virtual Group GroupCodeNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
