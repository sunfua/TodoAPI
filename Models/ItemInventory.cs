using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemInventory
    {
        public string ItemCode { get; set; }
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public byte Status { get; set; }
    }
}
