﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RolePermission
    {
        public int RoleObjectId { get; set; }
        public string GroupCode { get; set; }

        public virtual Group GroupCodeNavigation { get; set; }
        public virtual RoleObject RoleObject { get; set; }
    }
}
