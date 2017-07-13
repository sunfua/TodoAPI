using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Machine
    {
        public Machine()
        {
            PrintedMatterMachine = new HashSet<PrintedMatterMachine>();
        }

        public string MachineCode { get; set; }
        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public string MachineName { get; set; }
        public string MachineIp { get; set; }
        public string MachineRequestCode { get; set; }
        public string MachineKey { get; set; }
        public string Description { get; set; }

        public virtual ICollection<PrintedMatterMachine> PrintedMatterMachine { get; set; }
        public virtual Counter Counter { get; set; }
    }
}
