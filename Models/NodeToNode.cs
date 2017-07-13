using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class NodeToNode
    {
        public string FromNodeName { get; set; }
        public string ToNodeName { get; set; }

        public virtual Node FromNodeNameNavigation { get; set; }
        public virtual Node ToNodeNameNavigation { get; set; }
    }
}
