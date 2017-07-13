using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Bc37
    {
        public Bc37()
        {
            MailtripTransportBc37 = new HashSet<MailtripTransportBc37>();
            MailtripTransportPostBag = new HashSet<MailtripTransportPostBag>();
            ShiftHandoverBc37 = new HashSet<ShiftHandoverBc37>();
        }

        public int Bc37index { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string TransportTypeCode { get; set; }
        public byte Status { get; set; }
        public string Bc37date { get; set; }
        public string ConfirmUser { get; set; }
        public string ConfirmPoscode { get; set; }
        public string CreateUser { get; set; }
        public string CreatePoscode { get; set; }
        public string Bc37code { get; set; }
        public DateTime? ConfirmDate { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public int? TotalOtherPostBag { get; set; }
        public double? TotalWeightOtherPostBag { get; set; }
        public int? TotalPhbcpostBag { get; set; }
        public double? TotalWeightPhbcpostBag { get; set; }
        public string MailRouteCode { get; set; }
        public string MailRouteFromPoscode { get; set; }
        public string MailRouteScheduleCode { get; set; }
        public DateTime? SendingTime { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<MailtripTransportBc37> MailtripTransportBc37 { get; set; }
        public virtual ICollection<MailtripTransportPostBag> MailtripTransportPostBag { get; set; }
        public virtual ICollection<ShiftHandoverBc37> ShiftHandoverBc37 { get; set; }
    }
}
