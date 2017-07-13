using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DomesticCollectionFreight
    {
        public string CollectionCode { get; set; }
        public string DomesticFreighRuleCode { get; set; }
        public string ServiceCode { get; set; }
        public double? FromMoney { get; set; }
        public double? ToMoney { get; set; }
        public int? CalculateMethod { get; set; }
        public double? CollectionFreight { get; set; }
        public double? CollectionFreightPercent { get; set; }
        public double? MoneyStep { get; set; }

        public virtual DomesticFreightRule DomesticFreightRule { get; set; }
    }
}
