using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RangeSolution
    {
        public string RangeCode { get; set; }
        public string SolutionCode { get; set; }

        public virtual Range RangeCodeNavigation { get; set; }
        public virtual Solution SolutionCodeNavigation { get; set; }
    }
}
