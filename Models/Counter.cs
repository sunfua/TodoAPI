using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Counter
    {
        public Counter()
        {
            Dispatch = new HashSet<Dispatch>();
            Machine = new HashSet<Machine>();
        }

        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public string CounterName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Dispatch> Dispatch { get; set; }
        public virtual ICollection<Machine> Machine { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
