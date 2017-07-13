using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupMenu = new HashSet<GroupMenu>();
            GroupRole = new HashSet<GroupRole>();
            RolePermission = new HashSet<RolePermission>();
            UserGroup = new HashSet<UserGroup>();
        }

        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<GroupMenu> GroupMenu { get; set; }
        public virtual ICollection<GroupRole> GroupRole { get; set; }
        public virtual ICollection<RolePermission> RolePermission { get; set; }
        public virtual ICollection<UserGroup> UserGroup { get; set; }
    }
}
