using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Service
    {
        public Service()
        {
            Claim = new HashSet<Claim>();
            CollectionFreightStep = new HashSet<CollectionFreightStep>();
            Deduction = new HashSet<Deduction>();
            DeliveryRouteService = new HashSet<DeliveryRouteService>();
            DomesticCompensateRule = new HashSet<DomesticCompensateRule>();
            DomesticServiceSurchange = new HashSet<DomesticServiceSurchange>();
            ExchangeRelationship = new HashSet<ExchangeRelationship>();
            InternationalCompensateRule = new HashSet<InternationalCompensateRule>();
            InternationalFreightRule = new HashSet<InternationalFreightRule>();
            InternationalFreightSharingRule = new HashSet<InternationalFreightSharingRule>();
            InternationalMailFreightRule = new HashSet<InternationalMailFreightRule>();
            InternationalReturnFreightRule = new HashSet<InternationalReturnFreightRule>();
            InternationalServiceSurchange = new HashSet<InternationalServiceSurchange>();
            InternationalTransitFreightRule = new HashSet<InternationalTransitFreightRule>();
            Item = new HashSet<Item>();
            LetterMoneyOrderRule = new HashSet<LetterMoneyOrderRule>();
            LimitWeight = new HashSet<LimitWeight>();
            MailRouteService = new HashSet<MailRouteService>();
            MenuService = new HashSet<MenuService>();
            Posservice = new HashSet<Posservice>();
            PostBagType = new HashSet<PostBagType>();
            QualityTargetRule = new HashSet<QualityTargetRule>();
            RevenueSharingRule = new HashSet<RevenueSharingRule>();
            ServiceCommodityType = new HashSet<ServiceCommodityType>();
            ServiceConfiguration = new HashSet<ServiceConfiguration>();
            ServiceItemType = new HashSet<ServiceItemType>();
            ServicePhase = new HashSet<ServicePhase>();
            ServicePosconfiguration = new HashSet<ServicePosconfiguration>();
            ServicePrintedMatter = new HashSet<ServicePrintedMatter>();
            ServiceProperty = new HashSet<ServiceProperty>();
            ServiceSaleChannel = new HashSet<ServiceSaleChannel>();
            Vasusing = new HashSet<Vasusing>();
        }

        public string ServiceCode { get; set; }
        public string ShortName { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public string ServiceTypeCode { get; set; }
        public string SupplyScope { get; set; }
        public string ImageName { get; set; }
        public string AutomaticGenerationCharacterFrom { get; set; }
        public string AutomaticGenerationCharacterTo { get; set; }
        public string PrintCharacterFrom { get; set; }
        public string PrintCharacterTo { get; set; }
        public string ServicePriorityCode { get; set; }
        public bool? IsAllowNegotiating { get; set; }
        public double? LightDivideFactor { get; set; }
        public double? Vatpercentage { get; set; }
        public int? AirCoefficientConvertWeight { get; set; }
        public int? SurfaceCoefficientConvertWeight { get; set; }
        public string ShortcutKey { get; set; }
        public int? OrderIndex { get; set; }

        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<CollectionFreightStep> CollectionFreightStep { get; set; }
        public virtual ICollection<Deduction> Deduction { get; set; }
        public virtual ICollection<DeliveryRouteService> DeliveryRouteService { get; set; }
        public virtual ICollection<DomesticCompensateRule> DomesticCompensateRule { get; set; }
        public virtual ICollection<DomesticServiceSurchange> DomesticServiceSurchange { get; set; }
        public virtual ICollection<ExchangeRelationship> ExchangeRelationship { get; set; }
        public virtual ICollection<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual ICollection<InternationalFreightRule> InternationalFreightRule { get; set; }
        public virtual ICollection<InternationalFreightSharingRule> InternationalFreightSharingRule { get; set; }
        public virtual ICollection<InternationalMailFreightRule> InternationalMailFreightRule { get; set; }
        public virtual ICollection<InternationalReturnFreightRule> InternationalReturnFreightRule { get; set; }
        public virtual ICollection<InternationalServiceSurchange> InternationalServiceSurchange { get; set; }
        public virtual ICollection<InternationalTransitFreightRule> InternationalTransitFreightRule { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<LetterMoneyOrderRule> LetterMoneyOrderRule { get; set; }
        public virtual ICollection<LimitWeight> LimitWeight { get; set; }
        public virtual ICollection<MailRouteService> MailRouteService { get; set; }
        public virtual ICollection<MenuService> MenuService { get; set; }
        public virtual ICollection<Posservice> Posservice { get; set; }
        public virtual ICollection<PostBagType> PostBagType { get; set; }
        public virtual ICollection<QualityTargetRule> QualityTargetRule { get; set; }
        public virtual ICollection<RevenueSharingRule> RevenueSharingRule { get; set; }
        public virtual ICollection<ServiceCommodityType> ServiceCommodityType { get; set; }
        public virtual ICollection<ServiceConfiguration> ServiceConfiguration { get; set; }
        public virtual ICollection<ServiceItemType> ServiceItemType { get; set; }
        public virtual ICollection<ServicePhase> ServicePhase { get; set; }
        public virtual ICollection<ServicePosconfiguration> ServicePosconfiguration { get; set; }
        public virtual ICollection<ServicePrintedMatter> ServicePrintedMatter { get; set; }
        public virtual ICollection<ServiceProperty> ServiceProperty { get; set; }
        public virtual ICollection<ServiceSaleChannel> ServiceSaleChannel { get; set; }
        public virtual ICollection<Vasusing> Vasusing { get; set; }
        public virtual ServicePriority ServicePriorityCodeNavigation { get; set; }
        public virtual ServiceType ServiceTypeCodeNavigation { get; set; }
    }
}
