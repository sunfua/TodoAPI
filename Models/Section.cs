using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Section
    {
        public string SectionCode { get; set; }
        public string Poscode { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }

        public virtual Pos PoscodeNavigation { get; set; }
    }
}
