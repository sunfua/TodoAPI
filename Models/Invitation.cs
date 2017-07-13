using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Invitation
    {
        public string ItemCode { get; set; }
        public DateTime InvitationDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int? InvitationType { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
