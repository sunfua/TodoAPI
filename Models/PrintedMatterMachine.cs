using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PrintedMatterMachine
    {
        public string PrintedMatterCode { get; set; }
        public string MachineCode { get; set; }
        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public string PrinterName { get; set; }

        public virtual PrintedMatter PrintedMatterCodeNavigation { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
