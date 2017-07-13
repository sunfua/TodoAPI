using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemChangedReason
    {
        public string ItemCode { get; set; }
        public int ChangeReasonCode { get; set; }
    }
}
