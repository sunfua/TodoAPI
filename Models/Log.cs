using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Log
    {
        public int LogIndex { get; set; }
        public string Poscode { get; set; }
        public string Username { get; set; }
        public DateTime? LogDate { get; set; }
        public byte? LogType { get; set; }
        public string LogContent { get; set; }

        public virtual User User { get; set; }
    }
}
