using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class UnitType
    {
        public UnitType()
        {
            Unit = new HashSet<Unit>();
        }

        public string UnitTypeCode { get; set; }
        public string UnitTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Unit> Unit { get; set; }
    }
}
