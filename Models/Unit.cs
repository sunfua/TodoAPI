using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Unit
    {
        public Unit()
        {
            Pos = new HashSet<Pos>();
        }

        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public string ParentUnitCode { get; set; }
        public string CommuneCode { get; set; }
        public string UnitTypeCode { get; set; }

        public virtual ICollection<Pos> Pos { get; set; }
        public virtual Commune CommuneCodeNavigation { get; set; }
        public virtual Unit ParentUnitCodeNavigation { get; set; }
        public virtual ICollection<Unit> InverseParentUnitCodeNavigation { get; set; }
        public virtual UnitType UnitTypeCodeNavigation { get; set; }
    }
}
