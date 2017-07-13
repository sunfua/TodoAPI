using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Poslevel
    {
        public Poslevel()
        {
            Pos = new HashSet<Pos>();
        }

        public string PoslevelCode { get; set; }
        public string PoslevelName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Pos> Pos { get; set; }
    }
}
