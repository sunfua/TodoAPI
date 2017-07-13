﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Affair
    {
        public int AffairIndex { get; set; }
        public string ItemCode { get; set; }
        public string AcceptancePoscode { get; set; }
        public DateTime? AffairDate { get; set; }
        public string InputUser { get; set; }
        public byte? AffairType { get; set; }
        public byte? Status { get; set; }
        public string ReceiverAddressOld { get; set; }
        public string SenderAddressOld { get; set; }
        public string ReceiverIdentificationOld { get; set; }
        public DateTime? ReceiverIssueDate { get; set; }
        public string ReceiverIssueCountry { get; set; }
        public double? CollectionMoney { get; set; }
        public double? ReturnMoney { get; set; }
        public string ReceiverFullnameOld { get; set; }
        public double? StatePriceFreightOld { get; set; }
        public string CollectionPerson { get; set; }
        public string ReturnPerson { get; set; }
        public double? AffairFreight { get; set; }
        public string ReceiverAddressNew { get; set; }
        public string SenderAddressNew { get; set; }
        public string ReceiverIdentificationNew { get; set; }
        public string ReceiverFullnameNew { get; set; }
        public double? StatePriceFreightNew { get; set; }
        public string ProvinceOld { get; set; }
        public string ProvinceNew { get; set; }
        public string DistrictOld { get; set; }
        public string DistrictNew { get; set; }
        public byte? Module { get; set; }
        public string AffairContent { get; set; }
        public string Processing { get; set; }
        public string MailTripNumber { get; set; }
        public string PostBagNumber { get; set; }
        public string Demonstration { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public double? TotalWeight { get; set; }
        public int? TotalBag { get; set; }
        public string MailRouteCode { get; set; }
        public string ReceiverPosCode { get; set; }
        public string Bc43code { get; set; }
        public bool? IsBatch { get; set; }
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string ReceiverFullname { get; set; }
        public string ReceiverContact { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverAddressCode { get; set; }
        public string ReceiverTaxCode { get; set; }
        public string ReceiverIdentification { get; set; }
        public double? MainFreight { get; set; }
        public string ToPoscode { get; set; }
        public string AffairNumber { get; set; }
        public double? FreightCod { get; set; }
        public double? FreightVatcod { get; set; }
        public double? FreightCodold { get; set; }
        public double? FreightVatcodold { get; set; }
        public double? AmountCod { get; set; }
        public double? AmountCodold { get; set; }
        public byte? StatusItem { get; set; }
        public double? TotalFreightServed { get; set; }
        public double? TotalFreightEditCod { get; set; }
        public double? TotalFreightCancelCod { get; set; }
        public double? TotalFreightForward { get; set; }
        public double? TotalFreightReturn { get; set; }
        public double? FreightCoddifference { get; set; }
        public double? FreightBatchDifference { get; set; }
        public double? TotalFreightCustomer { get; set; }
        public bool? IsAirmail { get; set; }
        public bool? IsRefundByReceiver { get; set; }
        public string BatchCode { get; set; }
        public string ClosedPoscode { get; set; }
        public DateTime? ClosedTime { get; set; }
        public int? AffairCodstatus { get; set; }
        public int? AffairLevel { get; set; }
        public DateTime? ApprovedDateLevelOne { get; set; }
        public string ApprovedPoslevelOne { get; set; }
        public string ApprovedUserLevelOne { get; set; }
        public string ApprovedContentLevelOne { get; set; }
        public DateTime? ApprovedDateLevelTwo { get; set; }
        public string ApprovedPoslevelTwo { get; set; }
        public string ApprovedUserLevelTwo { get; set; }
        public string ApprovedContentLevelTwo { get; set; }
        public string TransactionsReceiverCode { get; set; }
        public string TransactionsPaymentCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public double? TotalWeightOld { get; set; }
        public double? TotalFreightVatold { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
    }
}
