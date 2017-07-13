using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ExchangeRate
    {
        public ExchangeRate()
        {
            InternationalFreightSharing = new HashSet<InternationalFreightSharing>();
            Item = new HashSet<Item>();
        }

        public string ExchangeRateCode { get; set; }
        public string ExchangeCode { get; set; }
        public string ExchangeRateCodeBased { get; set; }
        public DateTime ValueDate { get; set; }
        public double Rate { get; set; }

        public virtual ICollection<InternationalFreightSharing> InternationalFreightSharing { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual Exchange ExchangeCodeNavigation { get; set; }
    }
}
