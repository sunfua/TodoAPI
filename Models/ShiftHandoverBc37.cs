using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ShiftHandoverBc37
    {
        public string Poscode { get; set; }
        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string CounterCode { get; set; }
        public string Bc37date { get; set; }
        public int Bc37index { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string TransportTypeCode { get; set; }
        public byte Status { get; set; }

        public virtual ShiftHandover ShiftHandover { get; set; }
        public virtual Bc37 Bc37 { get; set; }
    }
}
