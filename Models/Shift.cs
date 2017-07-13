using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Dispatch = new HashSet<Dispatch>();
            ShiftHandover = new HashSet<ShiftHandover>();
        }

        public string ShiftCode { get; set; }
        public string Poscode { get; set; }
        public string ShiftName { get; set; }
        public DateTime? StartHour { get; set; }
        public DateTime? FinishHour { get; set; }

        public virtual ICollection<Dispatch> Dispatch { get; set; }
        public virtual ICollection<ShiftHandover> ShiftHandover { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
