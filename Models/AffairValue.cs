using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class AffairValue
    {
        public int AffairId { get; set; }
        public string AffairName { get; set; }
        public double? Value { get; set; }
    }
}
