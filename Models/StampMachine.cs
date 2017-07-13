using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class StampMachine
    {
        public StampMachine()
        {
            StampMachineFeight = new HashSet<StampMachineFeight>();
        }

        public string Poscode { get; set; }
        public string StampMachineNumber { get; set; }
        public string StampMachineName { get; set; }

        public virtual ICollection<StampMachineFeight> StampMachineFeight { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
