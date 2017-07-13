using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bd21disscusion
    {
        public DateTime CreatedDate { get; set; }
        public string MailtripPos { get; set; }
        public string Bc43code { get; set; }
        public string FromPosCode { get; set; }
        public string DisscusionContent { get; set; }
        public string ReplyUser { get; set; }
        public string AttachmentFileName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
