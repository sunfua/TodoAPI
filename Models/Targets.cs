using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Targets
    {
        public Targets()
        {
            TargetParameters = new HashSet<TargetParameters>();
            TargetValues = new HashSet<TargetValues>();
        }

        public string TargetCode { get; set; }
        public string TargetName { get; set; }
        public byte? Type { get; set; }
        public string TargetCatalogeCode { get; set; }
        public string QuantityFormula { get; set; }
        public string RevenueFormula { get; set; }
        public string CashFormula { get; set; }
        public string DebtFormula { get; set; }
        public string PaidFormula { get; set; }
        public bool? IsBold { get; set; }
        public bool? IsItalic { get; set; }
        public bool? IsUnderline { get; set; }
        public string Vatformula { get; set; }
        public string OutFormula { get; set; }
        public string InFormula { get; set; }
        public string UnitType { get; set; }
        public string DeliveryFormula { get; set; }
        public string NotInvoiceFormula { get; set; }
        public string VatpercentFormula { get; set; }

        public virtual ICollection<TargetParameters> TargetParameters { get; set; }
        public virtual ICollection<TargetValues> TargetValues { get; set; }
        public virtual TargetCataloge TargetCatalogeCodeNavigation { get; set; }
    }
}
