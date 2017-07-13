using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Delivery
    {
        public int DeliveryIndex { get; set; }
        public string ToPoscode { get; set; }
        public string ItemCode { get; set; }
        public string CauseCode { get; set; }
        public string SolutionCode { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryCertificateName { get; set; }
        public string DeliveryCertificateNumber { get; set; }
        public DateTime? DeliveryCertificateDateOfIssue { get; set; }
        public string DeliveryCertificatePlaceOfIssue { get; set; }
        public bool? IsDeliverable { get; set; }
        public string DeliveryNote { get; set; }
        public string RealReciverName { get; set; }
        public string RealReceiverIdentification { get; set; }
        public string DeliveryMachine { get; set; }
        public string DeliveryUser { get; set; }
        public string InputingUser { get; set; }
        public double? ReturningMoney { get; set; }
        public DateTime? ReturningMoneyDate { get; set; }
        public double? CollectionMoney { get; set; }
        public DateTime? CollectionMoneyDate { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public DateTime? InputDate { get; set; }
        public bool? SendMailSuccess { get; set; }
        public DateTime? SendMailDate { get; set; }
        public bool? SendSmssuccess { get; set; }
        public DateTime? SendSmsdate { get; set; }
        public double? Codamount { get; set; }
        public double? Codfreight { get; set; }
        public double? PostageFreight { get; set; }
        public double? AddedFreight { get; set; }
        public double? ReturnFreight { get; set; }
        public double? OtherFreight { get; set; }
        public string DeliveryCertificateOtherName { get; set; }
        public string ObjectTransfer { get; set; }
        public bool? DeliveryReturn { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
        public int? HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string CounterCode { get; set; }
        public string Poscode { get; set; }
        public string PostmanCode { get; set; }
        public string PostmanName { get; set; }
        public string DeliveryRouteCode { get; set; }
        public string DeliveryRouteName { get; set; }

        public virtual Item ItemCodeNavigation { get; set; }
        public virtual CauseSolution CauseSolution { get; set; }
    }
}
