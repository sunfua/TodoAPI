using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Postype
    {
        public Postype()
        {
            Pos = new HashSet<Pos>();
        }

        public string PostypeCode { get; set; }
        public string PostypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Pos> Pos { get; set; }
    }
}
