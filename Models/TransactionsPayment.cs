using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionsPayment
    {
        public TransactionsPayment()
        {
            TransactionsPaymentRevert = new HashSet<TransactionsPaymentRevert>();
        }

        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public string TransactionsPaymentCode { get; set; }
        public string Poscode { get; set; }
        public string TransactionsPaymentChannel { get; set; }
        public string PaymentUserName { get; set; }
        public DateTime? PaymentDateTime { get; set; }
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
        public bool? Activated { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<TransactionsPaymentRevert> TransactionsPaymentRevert { get; set; }
        public virtual TransactionsCollection TransactionsCollection { get; set; }
    }
}
