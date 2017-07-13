using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PostBag
    {
        public PostBag()
        {
            Dispatch = new HashSet<Dispatch>();
            MailtripTransportPostBag = new HashSet<MailtripTransportPostBag>();
            ShiftHandoverPostBag = new HashSet<ShiftHandoverPostBag>();
            TracePostBag = new HashSet<TracePostBag>();
        }

        public int PostBagIndex { get; set; }
        public string PostBagTypeCode { get; set; }
        public bool F { get; set; }
        public string FromPoscode { get; set; }
        public string ToPoscode { get; set; }
        public string MailTripType { get; set; }
        public string ServiceCode { get; set; }
        public string Year { get; set; }
        public string MailTripNumber { get; set; }
        public string PostBagNumber { get; set; }
        public double Weight { get; set; }
        public byte? Status { get; set; }
        public int? Quantity { get; set; }
        public bool? IsPrinted { get; set; }
        public DateTime? Bc37date { get; set; }
        public DateTime? PackagingTime { get; set; }
        public string PackagingUser { get; set; }
        public string PackagingMachine { get; set; }
        public DateTime? OpeningTime { get; set; }
        public string OpeningMachine { get; set; }
        public string OpeningUser { get; set; }
        public DateTime? IncomingDate { get; set; }
        public double? CaseWeight { get; set; }
        public bool? IsDiscrete { get; set; }
        public bool? IsDeliveryRoute { get; set; }
        public string PostBagCode { get; set; }
        public string Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public double? PostBagWeightConvert { get; set; }

        public virtual ICollection<Dispatch> Dispatch { get; set; }
        public virtual ICollection<MailtripTransportPostBag> MailtripTransportPostBag { get; set; }
        public virtual ICollection<ShiftHandoverPostBag> ShiftHandoverPostBag { get; set; }
        public virtual ICollection<TracePostBag> TracePostBag { get; set; }
        public virtual PostBagType PostBagTypeCodeNavigation { get; set; }
        public virtual Mailtrip Mailtrip { get; set; }
    }
}
