using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ClaimResponse
    {
        public int ClaimResponseNumber { get; set; }
        public string ReceivingClaimPoscode { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public int ClaimNumber { get; set; }
        public DateTime? SendingTime { get; set; }
        public DateTime? ReceivingTime { get; set; }
        public string SendingUser { get; set; }
        public string ReceivingUser { get; set; }
        public string Answer { get; set; }
        public string Question { get; set; }
        public bool? IsError { get; set; }
        public byte? Status { get; set; }
        public DateTime? AnswerDate { get; set; }
        public string AnswerRelatePos { get; set; }
        public int? ClaimConclusion { get; set; }
        public int? ClaimResult { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Claim Claim { get; set; }
    }
}
