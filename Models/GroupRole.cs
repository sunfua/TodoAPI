﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class GroupRole
    {
        public string GroupCode { get; set; }
        public string RoleCode { get; set; }

        public virtual Group GroupCodeNavigation { get; set; }
        public virtual Role RoleCodeNavigation { get; set; }
    }
}
