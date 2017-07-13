using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RoleObject
    {
        public RoleObject()
        {
            RolePermission = new HashSet<RolePermission>();
        }

        public int RoleObjectId { get; set; }
        public int ObjectRefId { get; set; }
        public int RolesGrantPermissionId { get; set; }

        public virtual ICollection<RolePermission> RolePermission { get; set; }
        public virtual ObjectRef ObjectRef { get; set; }
        public virtual RolesGrantPermission RolesGrantPermission { get; set; }
    }
}
