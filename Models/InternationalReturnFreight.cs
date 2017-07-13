using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class InternationalReturnFreight
    {
        public string InternationalFreightSharingCode { get; set; }
        public string ServiceCode { get; set; }
        public double? FrieghtPerWeight { get; set; }
        public double? FreightPerItem { get; set; }
        public string CountryCode { get; set; }
        public string TransportTypeCode { get; set; }
        public string ExchangeRateCode { get; set; }
        public string TransitCountryCode { get; set; }
        public bool? TransitType { get; set; }
        public bool? PaymentMethod { get; set; }
        public double? FreightPerBag { get; set; }

        public virtual InternationalReturnFreightRule InternationalReturnFreightRule { get; set; }
    }
}
