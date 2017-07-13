using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalFreightSharing
    {
        public string InternationalFreightSharingCode { get; set; }
        public string ServiceCode { get; set; }
        public double? FrieghtPerWeight { get; set; }
        public double? FreightPerItem { get; set; }
        public string CountryCode { get; set; }
        public string TransportTypeCode { get; set; }
        public string ExchangeRateCode { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
        public virtual ExchangeRate ExchangeRateCodeNavigation { get; set; }
        public virtual TransportType TransportTypeCodeNavigation { get; set; }
        public virtual InternationalFreightSharingRule InternationalFreightSharingRule { get; set; }
    }
}
