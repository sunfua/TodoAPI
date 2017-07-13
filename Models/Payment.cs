using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Payment
    {
        public string InvoiceNumber { get; set; }
        public string CustomerCode { get; set; }
        public string Poscode { get; set; }
        public DateTime? PaymentDate { get; set; }
        public double? PaymentMoney { get; set; }
        public string InputUser { get; set; }
        public string Note { get; set; }

        public virtual Customer CustomerCodeNavigation { get; set; }
    }
}
