using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class SynchronizationHistory
    {
        public string MessageTypeName { get; set; }
        public DateTime SyncDate { get; set; }
        public string SyncUser { get; set; }
    }
}
