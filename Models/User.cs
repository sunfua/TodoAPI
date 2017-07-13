using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class User
    {
        public User()
        {
            ActivityLog = new HashSet<ActivityLog>();
            Log = new HashSet<Log>();
            PostmanDeliveryRoute = new HashSet<PostmanDeliveryRoute>();
            UserGroup = new HashSet<UserGroup>();
        }

        public string Username { get; set; }
        public string FullName { get; set; }
        public bool? Sex { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Poscode { get; set; }
        public string PassWord { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public bool? IsFromAd { get; set; }
        public bool? IsPosadmin { get; set; }
        public string UnitCode { get; set; }

        public virtual ICollection<ActivityLog> ActivityLog { get; set; }
        public virtual ICollection<Log> Log { get; set; }
        public virtual ICollection<PostmanDeliveryRoute> PostmanDeliveryRoute { get; set; }
        public virtual ICollection<UserGroup> UserGroup { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
