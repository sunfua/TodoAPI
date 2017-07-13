using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class StampMachineFeight
    {
        public string Poscode { get; set; }
        public string StampMachineNumber { get; set; }
        public DateTime DateInput { get; set; }
        public int? StartNumber { get; set; }
        public int? EndNumber { get; set; }

        public virtual StampMachine StampMachine { get; set; }
    }
}
