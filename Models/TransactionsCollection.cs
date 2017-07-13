using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionsCollection
    {
        public TransactionsCollection()
        {
            TraceTransactionsCollection = new HashSet<TraceTransactionsCollection>();
            TransactionsCollectionDetail = new HashSet<TransactionsCollectionDetail>();
            TransactionsPayment = new HashSet<TransactionsPayment>();
            TransactionsReceiver = new HashSet<TransactionsReceiver>();
        }

        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public DateTime? TransactionsCollectionDate { get; set; }
        public string Poscode { get; set; }
        public string TransactionsCollectionChannel { get; set; }
        public string ReceiverCustomerCode { get; set; }
        public string ReceiverFullName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverTel { get; set; }
        public int? ReceiverCertificateType { get; set; }
        public string ReceiverCertificateNumber { get; set; }
        public DateTime? ReceiverCertificateIssueDate { get; set; }
        public string ReceiverCertificatePlace { get; set; }
        public string ReceiverCertificateOtherName { get; set; }
        public string Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public double? Codamount { get; set; }
        public double? Codpostage { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<TraceTransactionsCollection> TraceTransactionsCollection { get; set; }
        public virtual ICollection<TransactionsCollectionDetail> TransactionsCollectionDetail { get; set; }
        public virtual ICollection<TransactionsPayment> TransactionsPayment { get; set; }
        public virtual ICollection<TransactionsReceiver> TransactionsReceiver { get; set; }
        public virtual Item ItemCodeNavigation { get; set; }
    }
}
