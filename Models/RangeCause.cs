﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RangeCause
    {
        public string RangeCode { get; set; }
        public string CauseCode { get; set; }

        public virtual Cause CauseCodeNavigation { get; set; }
        public virtual Range RangeCodeNavigation { get; set; }
    }
}
