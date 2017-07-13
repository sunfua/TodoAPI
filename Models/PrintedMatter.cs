using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PrintedMatter
    {
        public PrintedMatter()
        {
            PrintConfiguration = new HashSet<PrintConfiguration>();
            PrintedMatterMachine = new HashSet<PrintedMatterMachine>();
            PrintedMatterPhase = new HashSet<PrintedMatterPhase>();
            ServicePrintedMatter = new HashSet<ServicePrintedMatter>();
        }

        public string PrintedMatterCode { get; set; }
        public string PrintedMatterName { get; set; }
        public string Description { get; set; }
        public int? Quantity { get; set; }
        public int? OrderIndex { get; set; }
        public string ShortcutKey { get; set; }

        public virtual ICollection<PrintConfiguration> PrintConfiguration { get; set; }
        public virtual ICollection<PrintedMatterMachine> PrintedMatterMachine { get; set; }
        public virtual ICollection<PrintedMatterPhase> PrintedMatterPhase { get; set; }
        public virtual ICollection<ServicePrintedMatter> ServicePrintedMatter { get; set; }
    }
}
