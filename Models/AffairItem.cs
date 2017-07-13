using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class AffairItem
    {
        public int AffairIndex { get; set; }
        public string ItemCode { get; set; }
        public double? Vatfreight { get; set; }
        public double? SubFreight { get; set; }
        public double? TotalFreight { get; set; }
        public double? TotalFreightVat { get; set; }
        public double? TotalFreightDiscount { get; set; }
        public double? TotalFreightDiscountVat { get; set; }
        public double? PaymentFreight { get; set; }
        public double? PaymentFreightVat { get; set; }
        public double? PaymentFreightDiscount { get; set; }
        public double? PaymentFreightDiscountVat { get; set; }
        public double? RemainingFreight { get; set; }
        public double? RemainingFreightVat { get; set; }
        public double? RemainingFreightDiscount { get; set; }
        public double? RemainingFreightDiscountVat { get; set; }
        public double? OriginalVatfreight { get; set; }
        public double? OriginalSubFreight { get; set; }
        public double? OriginalTotalFreight { get; set; }
        public double? OriginalTotalFreightVat { get; set; }
        public double? OriginalTotalFreightDiscount { get; set; }
        public double? OriginalTotalFreightDiscountVat { get; set; }
        public double? OriginalPaymentFreight { get; set; }
        public double? OriginalPaymentFreightVat { get; set; }
        public double? OriginalPaymentFreightDiscount { get; set; }
        public double? OriginalPaymentFreightDiscountVat { get; set; }
        public double? OriginalRemainingFreight { get; set; }
        public double? OriginalRemainingFreightVat { get; set; }
        public double? OriginalRemainingFreightDiscount { get; set; }
        public double? OriginalRemainingFreightDiscountVat { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public double? TotalWeightOld { get; set; }
        public double? TotalFreightVatold { get; set; }
        public double? FuelSurchargeFreight { get; set; }
        public double? FarRegionFreight { get; set; }
        public double? AirSurchargeFreight { get; set; }
        public double? OtherFreight { get; set; }
        public double? FeedbackAmount { get; set; }
        public double? DiscountAmount { get; set; }
        public double? OriginalMainFreight { get; set; }
        public double? OriginalFuelSurchargeFreight { get; set; }
        public double? OriginalFarRegionFreight { get; set; }
        public double? OriginalAirSurchargeFreight { get; set; }
        public double? MainFreight { get; set; }
        public double? Vatpercentage { get; set; }
        public double? Total { get; set; }
        public double? OriginalVatpercentage { get; set; }
    }
}
