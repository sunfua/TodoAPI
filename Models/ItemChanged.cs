using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ItemChanged
    {
        public ItemChanged()
        {
            DetailItemChanged = new HashSet<DetailItemChanged>();
            ItemCommodityTypeChanged = new HashSet<ItemCommodityTypeChanged>();
            ItemPropertyValueChanged = new HashSet<ItemPropertyValueChanged>();
            ItemVaspropertyValueChanged = new HashSet<ItemVaspropertyValueChanged>();
            TransactionCollectionChanged = new HashSet<TransactionCollectionChanged>();
            ValueAddedServiceItemChanged = new HashSet<ValueAddedServiceItemChanged>();
        }

        public string ItemCode { get; set; }
        public int HandoverIndex { get; set; }
        public string ChangePoscode { get; set; }
        public int ChangeIndex { get; set; }
        public string AcceptancePoscode { get; set; }
        public string SenderFullname { get; set; }
        public string SenderAddress { get; set; }
        public string CustomerCode { get; set; }
        public string BatchCode { get; set; }
        public string ReceiverFullname { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverAddress { get; set; }
        public bool? IsDomestic { get; set; }
        public string CountryCode { get; set; }
        public string Poscode { get; set; }
        public bool? IsStatePrice { get; set; }
        public double? StatePriceValue { get; set; }
        public string SendingContent { get; set; }
        public string Note { get; set; }
        public string ItemTypeCode { get; set; }
        public DateTime? SendingTime { get; set; }
        public bool IsAirmail { get; set; }
        public double Weight { get; set; }
        public byte? Status { get; set; }
        public double TotalFreight { get; set; }
        public string EmployeeCode { get; set; }
        public string SenderJob { get; set; }
        public string ProvinceCode { get; set; }
        public double? LightItem { get; set; }
        public string SectionCode { get; set; }
        public string ReceiverJob { get; set; }
        public bool? IsOpened { get; set; }
        public string CertificateNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string SenderIdentification { get; set; }
        public DateTime? SenderIssueDate { get; set; }
        public string SenderIssueCountry { get; set; }
        public string ReceiverIdentification { get; set; }
        public DateTime? ReceiverIssueDate { get; set; }
        public string ReceiverIssueCountry { get; set; }
        public string SenderTel { get; set; }
        public double? MainFreight { get; set; }
        public double? Vatfreight { get; set; }
        public double? SubFreight { get; set; }
        public bool? IsPostFree { get; set; }
        public double? StatePriceFreight { get; set; }
        public int? PrintedNumber { get; set; }
        public string DataCode { get; set; }
        public string SenderCustomReference { get; set; }
        public double? RemainingFreight { get; set; }
        public string ReceiverCustomReference { get; set; }
        public bool? IsReturn { get; set; }
        public bool? IsCompensate { get; set; }
        public bool? IsForward { get; set; }
        public bool? IsAirmailForward { get; set; }
        public bool? IsAirmailReturn { get; set; }
        public bool? IsDebt { get; set; }
        public string MachineName { get; set; }
        public int? AcceptedIndex { get; set; }
        public int? Bc16index { get; set; }
        public int? IncomingIndex { get; set; }
        public string ServiceCode { get; set; }
        public string ReceiverDistrictCode { get; set; }
        public double? LetterMoneyOrderFreight { get; set; }
        public double? ValueAddedServiceFreightTotalFreight { get; set; }
        public string OrderCode { get; set; }
        public string SenderAddressCode { get; set; }
        public string ReceiverAddressCode { get; set; }
        public string SenderMobile { get; set; }
        public string SenderFax { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverMobile { get; set; }
        public string ReceiverFax { get; set; }
        public string ReceiverEmail { get; set; }
        public double? Discount { get; set; }
        public double? Abatement { get; set; }
        public byte? UndeliverableGuide { get; set; }
        public double? Width { get; set; }
        public double? Height { get; set; }
        public double? Length { get; set; }
        public string CheckSum { get; set; }
        public string ItemNumber { get; set; }
        public string ExchangeRateCode { get; set; }
        public string Codaddress { get; set; }
        public bool? Codpayment { get; set; }
        public string SenderDistrictCode { get; set; }
        public string ReceiverContact { get; set; }
        public string UndeliverableReason { get; set; }
        public string DecisionNo { get; set; }
        public DateTime? DecisionDate { get; set; }
        public int? ReturnDayNumber { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DiscountAmount { get; set; }
        public string ExecuteOrder { get; set; }
        public bool? InvoiceAttached { get; set; }
        public bool? OtherAttached { get; set; }
        public string OtherAttachedInfor { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public double? WeightConvert { get; set; }
        public bool? IsDiscount { get; set; }
        public bool? InvoiceExport { get; set; }
        public double? Total { get; set; }
        public int? AcceptedType { get; set; }
        public string SenderTaxCode { get; set; }
        public double? Vatpercentage { get; set; }
        public double? FuelSurchargeFreight { get; set; }
        public double? FarRegionFreight { get; set; }
        public double? AirSurchargeFreight { get; set; }
        public double? OtherFreight { get; set; }
        public double? TotalFreightVat { get; set; }
        public double? TotalFreightDiscount { get; set; }
        public double? TotalFreightDiscountVat { get; set; }
        public string ReceiverTaxCode { get; set; }
        public bool? FarRegion { get; set; }
        public bool? IsCollection { get; set; }
        public string CustomerAccountNo { get; set; }
        public bool? IsFeedback { get; set; }
        public double? FeedbackPercentage { get; set; }
        public double? FeedbackAmount { get; set; }
        public double? PaymentFreight { get; set; }
        public double? PaymentFreightVat { get; set; }
        public double? PaymentFreightDiscount { get; set; }
        public double? PaymentFreightDiscountVat { get; set; }
        public double? RemainingFreightVat { get; set; }
        public double? RemainingFreightDiscount { get; set; }
        public double? RemainingFreightDiscountVat { get; set; }
        public bool? DeliveryCounter { get; set; }
        public string AdviceOfReceiptCode { get; set; }
        public string ReceiverCommuneCode { get; set; }
        public string CheckContentOnDeliveryCode { get; set; }
        public string DestinationPoscode { get; set; }
        public bool? IsAffair { get; set; }
        public DateTime? ReturnBeforeDate { get; set; }
        public double? OrtherFreight { get; set; }
        public double? OriginalMainFreight { get; set; }
        public double? OriginalSubFreight { get; set; }
        public double? OriginalFuelSurchargeFreight { get; set; }
        public double? OriginalFarRegionFreight { get; set; }
        public double? OriginalAirSurchargeFreight { get; set; }
        public double? OriginalVatfreight { get; set; }
        public double? OriginalVatpercentage { get; set; }
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
        public string CustomerGroupCode { get; set; }
        public bool? IsEcommerce { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public string ReceiverCustomerCode { get; set; }
        public double? OldCodvalue { get; set; }
        public double? OldRemainingFreightDiscountVat { get; set; }
        public double? OldMainFreight { get; set; }
        public double? OldSubFreight { get; set; }
        public double? OldFuelSurchargeFreight { get; set; }
        public double? OldFarRegionFreight { get; set; }
        public double? OldAirSurchargeFreight { get; set; }
        public double? OldVatfreight { get; set; }
        public double? OldVatpercentage { get; set; }
        public double? OldTotalFreight { get; set; }
        public double? OldTotalFreightVat { get; set; }
        public double? OldTotalFreightDiscount { get; set; }
        public double? OldTotalFreightDiscountVat { get; set; }
        public double? OldPaymentFreight { get; set; }
        public double? OldPaymentFreightVat { get; set; }
        public double? OldPaymentFreightDiscount { get; set; }
        public double? OldPaymentFreightDiscountVat { get; set; }
        public double? OldRemainingFreight { get; set; }
        public double? OldRemainingFreightVat { get; set; }
        public double? OldRemainingFreightDiscount { get; set; }
        public double? OldWeight { get; set; }
        public double? OldConvertWeight { get; set; }
        public double? OldOriginalRemainingFreightDiscount { get; set; }
        public double? OldOriginalRemainingFreightDiscountVat { get; set; }
        public double? OldOriginalSubFreight { get; set; }
        public double? OldOriginalFuelSurchargeFreight { get; set; }
        public double? OldOriginalFarRegionFreight { get; set; }
        public double? OldOriginalAirSurchargeFreight { get; set; }
        public double? OldOriginalVatfreight { get; set; }
        public double? OldOriginalVatpercentage { get; set; }
        public double? OldOriginalTotalFreight { get; set; }
        public double? OldOriginalTotalFreightVat { get; set; }
        public double? OldOriginalTotalFreightDiscount { get; set; }
        public double? OldOriginalTotalFreightDiscountVat { get; set; }
        public double? OldOriginalPaymentFreight { get; set; }
        public double? OldOriginalPaymentFreightVat { get; set; }
        public double? OldOriginalPaymentFreightDiscount { get; set; }
        public double? OldOriginalPaymentFreightDiscountVat { get; set; }
        public double? OldOriginalRemainingFreight { get; set; }
        public double? OldOriginalRemainingFreightVat { get; set; }
        public int? ChangeReason { get; set; }
        public string ChangeNote { get; set; }
        public string DeliveryNote { get; set; }
        public int? ChangeType { get; set; }
        public bool? OldIsDebt { get; set; }
        public double? Codamount { get; set; }
        public double? OldCodamount { get; set; }
        public double? Codfreight { get; set; }
        public double? OldCodfreight { get; set; }
        public DateTime? ChangeDateTime { get; set; }
        public bool? IsC { get; set; }
        public bool? OldIsC { get; set; }
        public bool? OldIsPpa { get; set; }
        public bool? IsPpa { get; set; }
        public bool? IsCod { get; set; }
        public bool? OldIsCod { get; set; }

        public virtual ICollection<DetailItemChanged> DetailItemChanged { get; set; }
        public virtual ICollection<ItemCommodityTypeChanged> ItemCommodityTypeChanged { get; set; }
        public virtual ICollection<ItemPropertyValueChanged> ItemPropertyValueChanged { get; set; }
        public virtual ICollection<ItemVaspropertyValueChanged> ItemVaspropertyValueChanged { get; set; }
        public virtual ICollection<TransactionCollectionChanged> TransactionCollectionChanged { get; set; }
        public virtual ICollection<ValueAddedServiceItemChanged> ValueAddedServiceItemChanged { get; set; }
    }
}
