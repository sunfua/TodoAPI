using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MenuVersion
    {
        public string MenuCode { get; set; }
        public string VersionCode { get; set; }

        public virtual Menu MenuCodeNavigation { get; set; }
        public virtual Version VersionCodeNavigation { get; set; }
    }
}
