using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemForward
    {
        public string ItemCode { get; set; }
        public string Reason { get; set; }
        public double? Freight { get; set; }
        public DateTime ForwardDate { get; set; }
        public string ReceiverFullname { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverTel { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public bool? IsAirline { get; set; }
        public string Poscode { get; set; }
        public string ForwardPoscode { get; set; }
        public string ReceiverEmail { get; set; }
        public bool? IsDomestic { get; set; }
        public string DistrictCode { get; set; }
        public double? FreightVat { get; set; }
        public int? ForwardType { get; set; }
        public int? ForwardLocation { get; set; }
        public int? AffairIndex { get; set; }
        public string Note { get; set; }
        public string CommuneCode { get; set; }
        public string ReceiverFullnameOld { get; set; }
        public string ReceiverAddressOld { get; set; }
        public string CountryCodeOld { get; set; }
        public string ProvinceCodeOld { get; set; }
        public string DistrictCodeOld { get; set; }
        public string CommuneCodeOld { get; set; }
        public string ReceiverTelOld { get; set; }
        public string ReceiverMobileOld { get; set; }
        public string ReceiverFaxOld { get; set; }
        public string ReceiverEmailOld { get; set; }
        public string ReceiverContactOld { get; set; }
        public string ReceiverAddressCodeOld { get; set; }
        public string ReceiverTaxCodeOld { get; set; }
        public string ReceiverIdentificationOld { get; set; }
        public string PoscodeOld { get; set; }
        public double? MainFreight { get; set; }
        public double? SubFreight { get; set; }
        public double? FuelSurchargeFreight { get; set; }
        public double? FarRegionFreight { get; set; }
        public double? AirSurchargeFreight { get; set; }
        public double? Vatfreight { get; set; }
        public double? Vatpercentage { get; set; }
        public double? OriginalMainFreight { get; set; }
        public double? OriginalSubFreight { get; set; }
        public double? OriginalFuelSurchargeFreight { get; set; }
        public double? OriginalFarRegionFreight { get; set; }
        public double? OriginalAirSurchargeFreight { get; set; }
        public double? OriginalVatfreight { get; set; }
        public double? OriginalVatpercentage { get; set; }
        public double? OriginalFreight { get; set; }
        public double? OriginalFreightVat { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
