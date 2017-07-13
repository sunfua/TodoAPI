using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bd21affairResponse
    {
        public string AffairResponseNumber { get; set; }
        public string Bc43code { get; set; }
        public string FromPoscode { get; set; }
        public string Bd10fromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public DateTime? SendingTime { get; set; }
        public DateTime? ReceivingTime { get; set; }
        public bool? IsReceived { get; set; }
        public string ReasonNotAccept { get; set; }
        public DateTime? SentBackTime { get; set; }
        public string SendingUser { get; set; }
        public string ReceivingUser { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
        public bool? IsError { get; set; }
        public byte? Status { get; set; }
        public DateTime? AnswerDate { get; set; }
        public string AnswerUser { get; set; }
        public string AnswerAtRelatePos { get; set; }
        public bool? IsFinalAnswer { get; set; }
        public int? AffairResultCode { get; set; }
        public string AffairResultContent { get; set; }
        public string AttachmentFile { get; set; }
        public string AttachmentFileReply { get; set; }
        public bool? IsCompensate { get; set; }
        public DateTime? ResponseDateExpired { get; set; }
        public byte? Posorder { get; set; }
        public string OtherBd10code { get; set; }
        public bool? IsViewed { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Bc43 Bc43 { get; set; }
    }
}
