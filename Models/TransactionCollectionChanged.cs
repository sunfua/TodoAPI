using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransactionCollectionChanged
    {
        public string TransactionsCollectionCode { get; set; }
        public string ItemCode { get; set; }
        public int HandoverIndex { get; set; }
        public string ChangePoscode { get; set; }
        public int ChangeIndex { get; set; }
        public DateTime? TransactionsCollectionDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
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

        public virtual ItemChanged ItemChanged { get; set; }
    }
}
