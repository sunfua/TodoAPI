using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bc43type
    {
        public Bc43type()
        {
            Bc43 = new HashSet<Bc43>();
        }

        public int Bc43type1 { get; set; }
        public string Bc43typeName { get; set; }
        public string Bc43description { get; set; }
        public int? Bc43category { get; set; }

        public virtual ICollection<Bc43> Bc43 { get; set; }
    }
}
