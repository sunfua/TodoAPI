using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ShiftHandoverItem
    {
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string Poscode { get; set; }
        public string ItemCode { get; set; }
        public byte Status { get; set; }
        public string CounterCode { get; set; }
        public string ShiftCodeOlder { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public byte? Phase { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual ShiftHandover ShiftHandover { get; set; }
    }
}
