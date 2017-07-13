using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RangeUndeliveryGuide
    {
        public string RangeCode { get; set; }
        public byte UndeliveryGuideCode { get; set; }

        public virtual Range RangeCodeNavigation { get; set; }
        public virtual UndeliveryGuide UndeliveryGuideCodeNavigation { get; set; }
    }
}
