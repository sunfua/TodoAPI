﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class StoreBehavior
    {
        public StoreBehavior()
        {
            MessageTypeTable = new HashSet<MessageTypeTable>();
        }

        public int StoreBehaviorId { get; set; }
        public string StoreBehaviorName { get; set; }

        public virtual ICollection<MessageTypeTable> MessageTypeTable { get; set; }
    }
}
