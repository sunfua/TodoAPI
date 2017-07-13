using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Claim
    {
        public Claim()
        {
            ClaimItem = new HashSet<ClaimItem>();
            ClaimResponse = new HashSet<ClaimResponse>();
            ReceiverDomesticCompensate = new HashSet<ReceiverDomesticCompensate>();
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            SenderDomesticCompensate = new HashSet<SenderDomesticCompensate>();
            SenderInternationalCompensate = new HashSet<SenderInternationalCompensate>();
        }

        public int ClaimNumber { get; set; }
        public string RecevingClaimPoscode { get; set; }
        public DateTime ClaimTime { get; set; }
        public DateTime? ClaimReceivingTime { get; set; }
        public string ClaimPersonName { get; set; }
        public string ClaimPersonTel { get; set; }
        public string ClaimPersonEmail { get; set; }
        public string ClaimPersonAddress { get; set; }
        public string HeadOfRecevingUnit { get; set; }
        public byte? Status { get; set; }
        public string ClaimContent { get; set; }
        public DateTime? ClosingTime { get; set; }
        public string ClosingUser { get; set; }
        public string ServiceCode { get; set; }
        public string ClaimItemCode { get; set; }
        public bool? IsDomesticItem { get; set; }
        public bool? IsBigCustomer { get; set; }
        public string AcceptancePoscode { get; set; }
        public double? ItemWeight { get; set; }
        public double? ItemFreight { get; set; }
        public string ClaimPriorityCode { get; set; }
        public string AttachmentFileName { get; set; }
        public string ClaimTypeCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<ClaimItem> ClaimItem { get; set; }
        public virtual ICollection<ClaimResponse> ClaimResponse { get; set; }
        public virtual ICollection<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
        public virtual ICollection<SenderInternationalCompensate> SenderInternationalCompensate { get; set; }
        public virtual ClaimPriority ClaimPriorityCodeNavigation { get; set; }
        public virtual ClaimType ClaimTypeCodeNavigation { get; set; }
        public virtual Pos RecevingClaimPoscodeNavigation { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
