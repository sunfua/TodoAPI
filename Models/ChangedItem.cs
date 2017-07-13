using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ChangedItem
    {
        public string ItemCode { get; set; }
        public string ItemCodeOld { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual Item ItemCodeOldNavigation { get; set; }
    }
}
