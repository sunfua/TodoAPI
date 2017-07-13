using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalTransitFreight
    {
        public string ServiceCode { get; set; }
        public string InternationalFreightSharingCode { get; set; }
        public double? FrieghtPerWeight { get; set; }
        public double? FreightPerItem { get; set; }
        public double? FreightPerFraction { get; set; }
        public string CountryCode { get; set; }
        public string TransportTypeCode { get; set; }
        public string ExchangeRateCode { get; set; }
        public string TransitCountryCode { get; set; }
        public bool? TransitType { get; set; }
        public double? FreightPerBag { get; set; }
        public bool? PaymentMethod { get; set; }

        public virtual InternationalTransitFreightRule InternationalTransitFreightRule { get; set; }
    }
}
