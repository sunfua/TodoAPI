using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CustomerContract
    {
        public string ContractNumber { get; set; }
        public string CustomerCode { get; set; }
        public string Title { get; set; }
        public DateTime? SignDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? PaymentThirdParty { get; set; }
        public string ThirdPartyCompanyName { get; set; }
        public byte? Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverAddress { get; set; }
        public string PaymentFullName { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentAccount { get; set; }
        public string PaymentBank { get; set; }
        public string PaymentBranch { get; set; }
        public string PaymentFrequency { get; set; }

        public virtual Customer CustomerCodeNavigation { get; set; }
    }
}
