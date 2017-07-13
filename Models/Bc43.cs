using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bc43
    {
        public Bc43()
        {
            Bc43affair = new HashSet<Bc43affair>();
            Bd21affairResponse = new HashSet<Bd21affairResponse>();
        }

        public string Bc43code { get; set; }
        public string FromPosCode { get; set; }
        public string Bc37code { get; set; }
        public string ReasonCreateBc43 { get; set; }
        public int? Bc43type { get; set; }
        public string Bc43content { get; set; }
        public string Bc43creator { get; set; }
        public string Bc43leaderOfPos { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Bc37index { get; set; }
        public string Bc37fromPosCode { get; set; }
        public string Bc37toPosCode { get; set; }
        public string Bc37transportTypeCode { get; set; }
        public string Bc37date { get; set; }
        public string MailTripNumber { get; set; }
        public DateTime? MailTripDate { get; set; }
        public string MailTripStartingCode { get; set; }
        public string MailTripDestinationCode { get; set; }
        public string MailTripType { get; set; }
        public string MailTripServiceCode { get; set; }
        public string MailTripYear { get; set; }
        public string Bc43viewPos { get; set; }
        public string Bc43replyFromReceptionPos { get; set; }
        public string AttachmentFileName { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? ExpiredDateBigCustomer { get; set; }
        public int? Bc43subType { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<Bc43affair> Bc43affair { get; set; }
        public virtual ICollection<Bd21affairResponse> Bd21affairResponse { get; set; }
        public virtual Bc43type Bc43typeNavigation { get; set; }
    }
}
