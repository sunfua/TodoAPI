using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TargetValues
    {
        public string TargetCode { get; set; }
        public double Quantity { get; set; }
        public double? Revenue { get; set; }
        public double? Cash { get; set; }
        public double? Debt { get; set; }
        public double? Paid { get; set; }
        public double? Vat { get; set; }
        public double? Out { get; set; }
        public double? In { get; set; }
        public string Poscode { get; set; }
        public string InsertDate { get; set; }
        public bool? IsLast { get; set; }
        public double? Invoice { get; set; }
        public double? NotInvoice { get; set; }
        public double? Vatpercent { get; set; }
        public double? Delivery { get; set; }
        public double? Posdebt { get; set; }

        public virtual Targets TargetCodeNavigation { get; set; }
    }
}
