﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Range
    {
        public Range()
        {
            RangeCause = new HashSet<RangeCause>();
            RangeCommodityType = new HashSet<RangeCommodityType>();
            RangeServiceItemType = new HashSet<RangeServiceItemType>();
            RangeSolution = new HashSet<RangeSolution>();
            RangeUndeliveryGuide = new HashSet<RangeUndeliveryGuide>();
            RangeValueAddedServicePhase = new HashSet<RangeValueAddedServicePhase>();
        }

        public string RangeCode { get; set; }
        public string RangeName { get; set; }

        public virtual ICollection<RangeCause> RangeCause { get; set; }
        public virtual ICollection<RangeCommodityType> RangeCommodityType { get; set; }
        public virtual ICollection<RangeServiceItemType> RangeServiceItemType { get; set; }
        public virtual ICollection<RangeSolution> RangeSolution { get; set; }
        public virtual ICollection<RangeUndeliveryGuide> RangeUndeliveryGuide { get; set; }
        public virtual ICollection<RangeValueAddedServicePhase> RangeValueAddedServicePhase { get; set; }
    }
}
