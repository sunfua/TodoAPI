using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceItemRemaining
    {
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string Poscode { get; set; }
        public string CounterCode { get; set; }
        public string ServiceCode { get; set; }
        public int? ItemRemaining { get; set; }

        public virtual ShiftHandover ShiftHandover { get; set; }
    }
}
