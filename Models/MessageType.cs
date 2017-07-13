using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MessageType
    {
        public MessageType()
        {
            MessageTypeTable = new HashSet<MessageTypeTable>();
        }

        public string MessageTypeName { get; set; }
        public bool AllowSend { get; set; }
        public bool AllowGet { get; set; }
        public int? SyncPriority { get; set; }

        public virtual ICollection<MessageTypeTable> MessageTypeTable { get; set; }
    }
}
