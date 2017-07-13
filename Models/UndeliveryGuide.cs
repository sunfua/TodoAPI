using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class UndeliveryGuide
    {
        public UndeliveryGuide()
        {
            RangeUndeliveryGuide = new HashSet<RangeUndeliveryGuide>();
        }

        public byte UndeliveryGuideCode { get; set; }
        public string UndeliveryGuideName { get; set; }

        public virtual ICollection<RangeUndeliveryGuide> RangeUndeliveryGuide { get; set; }
    }
}
