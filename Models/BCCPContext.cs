using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TodoAPI.Models
{
    public partial class BCCPContext : DbContext
    {
        public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogType { get; set; }
        public virtual DbSet<Affair> Affair { get; set; }
        public virtual DbSet<AffairDetailItem> AffairDetailItem { get; set; }
        public virtual DbSet<AffairHistory> AffairHistory { get; set; }
        public virtual DbSet<AffairItem> AffairItem { get; set; }
        public virtual DbSet<AffairItemVaspropertyValue> AffairItemVaspropertyValue { get; set; }
        public virtual DbSet<AffairResponse> AffairResponse { get; set; }
        public virtual DbSet<AffairTransactionsCollection> AffairTransactionsCollection { get; set; }
        public virtual DbSet<AffairTransport> AffairTransport { get; set; }
        public virtual DbSet<AffairValue> AffairValue { get; set; }
        public virtual DbSet<AffairVasitem> AffairVasitem { get; set; }
        public virtual DbSet<ApplicationVersion> ApplicationVersion { get; set; }
        public virtual DbSet<Batch> Batch { get; set; }
        public virtual DbSet<BatchPos> BatchPos { get; set; }
        public virtual DbSet<Bc37> Bc37 { get; set; }
        public virtual DbSet<Bc37route> Bc37route { get; set; }
        public virtual DbSet<Bc37routeType> Bc37routeType { get; set; }
        public virtual DbSet<Bc43> Bc43 { get; set; }
        public virtual DbSet<Bc43affair> Bc43affair { get; set; }
        public virtual DbSet<Bc43dispatch> Bc43dispatch { get; set; }
        public virtual DbSet<Bc43postBag> Bc43postBag { get; set; }
        public virtual DbSet<Bc43type> Bc43type { get; set; }
        public virtual DbSet<BcnCommissiontodelivery> BcnCommissiontodelivery { get; set; }
        public virtual DbSet<BcnCommissiontodeliveryLevelWeight> BcnCommissiontodeliveryLevelWeight { get; set; }
        public virtual DbSet<BcnserviceList> BcnserviceList { get; set; }
        public virtual DbSet<Bd21affairResponse> Bd21affairResponse { get; set; }
        public virtual DbSet<Bd21disscusion> Bd21disscusion { get; set; }
        public virtual DbSet<BusinessDomain> BusinessDomain { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Cause> Cause { get; set; }
        public virtual DbSet<CauseCustomer> CauseCustomer { get; set; }
        public virtual DbSet<CauseSolution> CauseSolution { get; set; }
        public virtual DbSet<ChangeReason> ChangeReason { get; set; }
        public virtual DbSet<ChangedItem> ChangedItem { get; set; }
        public virtual DbSet<ChemicalType> ChemicalType { get; set; }
        public virtual DbSet<Claim> Claim { get; set; }
        public virtual DbSet<ClaimItem> ClaimItem { get; set; }
        public virtual DbSet<ClaimPriority> ClaimPriority { get; set; }
        public virtual DbSet<ClaimResponse> ClaimResponse { get; set; }
        public virtual DbSet<ClaimType> ClaimType { get; set; }
        public virtual DbSet<ClientReservation> ClientReservation { get; set; }
        public virtual DbSet<CollectionFreightStep> CollectionFreightStep { get; set; }
        public virtual DbSet<Column> Column { get; set; }
        public virtual DbSet<CommodityType> CommodityType { get; set; }
        public virtual DbSet<Commune> Commune { get; set; }
        public virtual DbSet<CommuneFreightRegion> CommuneFreightRegion { get; set; }
        public virtual DbSet<CommuneFreightRegionDeliveryAddress> CommuneFreightRegionDeliveryAddress { get; set; }
        public virtual DbSet<CommunicationConfig> CommunicationConfig { get; set; }
        public virtual DbSet<CompensateCategory> CompensateCategory { get; set; }
        public virtual DbSet<CompensateRate> CompensateRate { get; set; }
        public virtual DbSet<Configuration> Configuration { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Controls> Controls { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerBusinessDomain> CustomerBusinessDomain { get; set; }
        public virtual DbSet<CustomerContract> CustomerContract { get; set; }
        public virtual DbSet<CustomerGroup> CustomerGroup { get; set; }
        public virtual DbSet<DbVersion> DbVersion { get; set; }
        public virtual DbSet<Deduction> Deduction { get; set; }
        public virtual DbSet<DeductionDetail> DeductionDetail { get; set; }
        public virtual DbSet<DeductionPos> DeductionPos { get; set; }
        public virtual DbSet<DeductionProvince> DeductionProvince { get; set; }
        public virtual DbSet<DeleteParameter> DeleteParameter { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<DeliveryOther> DeliveryOther { get; set; }
        public virtual DbSet<DeliveryOtherTarget> DeliveryOtherTarget { get; set; }
        public virtual DbSet<DeliveryOtherTargetRule> DeliveryOtherTargetRule { get; set; }
        public virtual DbSet<DeliveryRevenueSharing> DeliveryRevenueSharing { get; set; }
        public virtual DbSet<DeliveryRoute> DeliveryRoute { get; set; }
        public virtual DbSet<DeliveryRouteService> DeliveryRouteService { get; set; }
        public virtual DbSet<DeliveryScoping> DeliveryScoping { get; set; }
        public virtual DbSet<DetailItem> DetailItem { get; set; }
        public virtual DbSet<DetailItemAffairCod> DetailItemAffairCod { get; set; }
        public virtual DbSet<DetailItemChanged> DetailItemChanged { get; set; }
        public virtual DbSet<DetailProvinceFreight> DetailProvinceFreight { get; set; }
        public virtual DbSet<DetailRegionFreight> DetailRegionFreight { get; set; }
        public virtual DbSet<DetailRegionFreightDeliveryAddress> DetailRegionFreightDeliveryAddress { get; set; }
        public virtual DbSet<DetailValueAddedServiceProvinceFreight> DetailValueAddedServiceProvinceFreight { get; set; }
        public virtual DbSet<DetailValueAddedServiceRegionFreight> DetailValueAddedServiceRegionFreight { get; set; }
        public virtual DbSet<DirectionRoute> DirectionRoute { get; set; }
        public virtual DbSet<Dispatch> Dispatch { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<DistrictFreightRegion> DistrictFreightRegion { get; set; }
        public virtual DbSet<DistrictFreightRegionDeliveryAddress> DistrictFreightRegionDeliveryAddress { get; set; }
        public virtual DbSet<DnnModuleControl> DnnModuleControl { get; set; }
        public virtual DbSet<DnnModuleControlPermission> DnnModuleControlPermission { get; set; }
        public virtual DbSet<DomesticCollectionFreight> DomesticCollectionFreight { get; set; }
        public virtual DbSet<DomesticCommodityType> DomesticCommodityType { get; set; }
        public virtual DbSet<DomesticCompensateRule> DomesticCompensateRule { get; set; }
        public virtual DbSet<DomesticFarRegion> DomesticFarRegion { get; set; }
        public virtual DbSet<DomesticFarRegionCommune> DomesticFarRegionCommune { get; set; }
        public virtual DbSet<DomesticFarRegionFreightStep> DomesticFarRegionFreightStep { get; set; }
        public virtual DbSet<DomesticFreightObject> DomesticFreightObject { get; set; }
        public virtual DbSet<DomesticFreightObjectFreight> DomesticFreightObjectFreight { get; set; }
        public virtual DbSet<DomesticFreightProperty> DomesticFreightProperty { get; set; }
        public virtual DbSet<DomesticFreightPropertyValue> DomesticFreightPropertyValue { get; set; }
        public virtual DbSet<DomesticFreightRule> DomesticFreightRule { get; set; }
        public virtual DbSet<DomesticFreightRuleItemTypeUsing> DomesticFreightRuleItemTypeUsing { get; set; }
        public virtual DbSet<DomesticFreightRuleLastUpdate> DomesticFreightRuleLastUpdate { get; set; }
        public virtual DbSet<DomesticFreightStep> DomesticFreightStep { get; set; }
        public virtual DbSet<DomesticFreightStepDeliveryAddress> DomesticFreightStepDeliveryAddress { get; set; }
        public virtual DbSet<DomesticServiceSurchange> DomesticServiceSurchange { get; set; }
        public virtual DbSet<DomesticSurchangeValueAddedServicePercent> DomesticSurchangeValueAddedServicePercent { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPerItem> DomesticValueAddedServiceFreightPerItem { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPerMoney> DomesticValueAddedServiceFreightPerMoney { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPerStockDay> DomesticValueAddedServiceFreightPerStockDay { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPerTotalItem> DomesticValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPerTotalItemInBatch> DomesticValueAddedServiceFreightPerTotalItemInBatch { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightPercentMainFreight> DomesticValueAddedServiceFreightPercentMainFreight { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightStep> DomesticValueAddedServiceFreightStep { get; set; }
        public virtual DbSet<DomesticValueAddedServiceFreightTotalWeight> DomesticValueAddedServiceFreightTotalWeight { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<EmailAccount> EmailAccount { get; set; }
        public virtual DbSet<Exchange> Exchange { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRate { get; set; }
        public virtual DbSet<ExchangeRelationship> ExchangeRelationship { get; set; }
        public virtual DbSet<ExchangeServiceHistory> ExchangeServiceHistory { get; set; }
        public virtual DbSet<FreightRegion> FreightRegion { get; set; }
        public virtual DbSet<FreightRegionDeliveryAddress> FreightRegionDeliveryAddress { get; set; }
        public virtual DbSet<GetDependOn> GetDependOn { get; set; }
        public virtual DbSet<GetParameter> GetParameter { get; set; }
/*        public virtual DbSet<GetType> GetType { get; set; }*/
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupMenu> GroupMenu { get; set; }
        public virtual DbSet<GroupProperty> GroupProperty { get; set; }
        public virtual DbSet<GroupRole> GroupRole { get; set; }
        public virtual DbSet<Holiday> Holiday { get; set; }
        public virtual DbSet<InlandFreight> InlandFreight { get; set; }
        public virtual DbSet<InternationalAirSurchargeFreight> InternationalAirSurchargeFreight { get; set; }
        public virtual DbSet<InternationalCommodityType> InternationalCommodityType { get; set; }
        public virtual DbSet<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual DbSet<InternationalCountryFreight> InternationalCountryFreight { get; set; }
        public virtual DbSet<InternationalCountryRegion> InternationalCountryRegion { get; set; }
        public virtual DbSet<InternationalFarRegionFreightStep> InternationalFarRegionFreightStep { get; set; }
        public virtual DbSet<InternationalFreight> InternationalFreight { get; set; }
        public virtual DbSet<InternationalFreightObject> InternationalFreightObject { get; set; }
        public virtual DbSet<InternationalFreightObjectFreight> InternationalFreightObjectFreight { get; set; }
        public virtual DbSet<InternationalFreightProperty> InternationalFreightProperty { get; set; }
        public virtual DbSet<InternationalFreightPropertyValue> InternationalFreightPropertyValue { get; set; }
        public virtual DbSet<InternationalFreightRegion> InternationalFreightRegion { get; set; }
        public virtual DbSet<InternationalFreightRule> InternationalFreightRule { get; set; }
        public virtual DbSet<InternationalFreightRuleItemTypeUsing> InternationalFreightRuleItemTypeUsing { get; set; }
        public virtual DbSet<InternationalFreightSharing> InternationalFreightSharing { get; set; }
        public virtual DbSet<InternationalFreightSharingRule> InternationalFreightSharingRule { get; set; }
        public virtual DbSet<InternationalFreightStep> InternationalFreightStep { get; set; }
        public virtual DbSet<InternationalMailFreightRule> InternationalMailFreightRule { get; set; }
        public virtual DbSet<InternationalReturnFreight> InternationalReturnFreight { get; set; }
        public virtual DbSet<InternationalReturnFreightRule> InternationalReturnFreightRule { get; set; }
        public virtual DbSet<InternationalServiceSurchange> InternationalServiceSurchange { get; set; }
        public virtual DbSet<InternationalSurchangeValueAddedServicePercent> InternationalSurchangeValueAddedServicePercent { get; set; }
        public virtual DbSet<InternationalTransitFreight> InternationalTransitFreight { get; set; }
        public virtual DbSet<InternationalTransitFreightRule> InternationalTransitFreightRule { get; set; }
        public virtual DbSet<InternationalValueAddedServiceCountryFreight> InternationalValueAddedServiceCountryFreight { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreight> InternationalValueAddedServiceFreight { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightPerItem> InternationalValueAddedServiceFreightPerItem { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightPerTotalItem> InternationalValueAddedServiceFreightPerTotalItem { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightPerTotalItemInBatch> InternationalValueAddedServiceFreightPerTotalItemInBatch { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightPerTotalWeight> InternationalValueAddedServiceFreightPerTotalWeight { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightPercentMainFreight> InternationalValueAddedServiceFreightPercentMainFreight { get; set; }
        public virtual DbSet<InternationalValueAddedServiceFreightStep> InternationalValueAddedServiceFreightStep { get; set; }
        public virtual DbSet<Invitation> Invitation { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemAdviceOfReceipt> ItemAdviceOfReceipt { get; set; }
        public virtual DbSet<ItemChanged> ItemChanged { get; set; }
        public virtual DbSet<ItemChangedReason> ItemChangedReason { get; set; }
        public virtual DbSet<ItemCommodityType> ItemCommodityType { get; set; }
        public virtual DbSet<ItemCommodityTypeChanged> ItemCommodityTypeChanged { get; set; }
        public virtual DbSet<ItemCompensate> ItemCompensate { get; set; }
        public virtual DbSet<ItemForward> ItemForward { get; set; }
        public virtual DbSet<ItemInventory> ItemInventory { get; set; }
        public virtual DbSet<ItemPropertyValue> ItemPropertyValue { get; set; }
        public virtual DbSet<ItemPropertyValueChanged> ItemPropertyValueChanged { get; set; }
        public virtual DbSet<ItemReturn> ItemReturn { get; set; }
        public virtual DbSet<ItemType> ItemType { get; set; }
        public virtual DbSet<ItemTypeNotUsedValueAddedService> ItemTypeNotUsedValueAddedService { get; set; }
        public virtual DbSet<ItemTypeUsedValueAddedService> ItemTypeUsedValueAddedService { get; set; }
        public virtual DbSet<ItemVaspropertyValue> ItemVaspropertyValue { get; set; }
        public virtual DbSet<ItemVaspropertyValueChanged> ItemVaspropertyValueChanged { get; set; }
        public virtual DbSet<LetterMoneyOrder> LetterMoneyOrder { get; set; }
        public virtual DbSet<LetterMoneyOrderRule> LetterMoneyOrderRule { get; set; }
        public virtual DbSet<LicenseInformation> LicenseInformation { get; set; }
        public virtual DbSet<LicenseStorage> LicenseStorage { get; set; }
        public virtual DbSet<LimitWeight> LimitWeight { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MailRoute> MailRoute { get; set; }
        public virtual DbSet<MailRoutePos> MailRoutePos { get; set; }
        public virtual DbSet<MailRouteSchedule> MailRouteSchedule { get; set; }
        public virtual DbSet<MailRouteService> MailRouteService { get; set; }
        public virtual DbSet<MailRouteType> MailRouteType { get; set; }
        public virtual DbSet<Mailtrip> Mailtrip { get; set; }
        public virtual DbSet<MailtripItem> MailtripItem { get; set; }
        public virtual DbSet<MailtripTransport> MailtripTransport { get; set; }
        public virtual DbSet<MailtripTransportBc37> MailtripTransportBc37 { get; set; }
        public virtual DbSet<MailtripTransportPostBag> MailtripTransportPostBag { get; set; }
        public virtual DbSet<MailtripTransportPostBagLog> MailtripTransportPostBagLog { get; set; }
        public virtual DbSet<MailtripTransportTrace> MailtripTransportTrace { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuParameter> MenuParameter { get; set; }
        public virtual DbSet<MenuService> MenuService { get; set; }
        public virtual DbSet<MenuVersion> MenuVersion { get; set; }
        public virtual DbSet<MessageType> MessageType { get; set; }
        public virtual DbSet<MessageTypeLastCall> MessageTypeLastCall { get; set; }
        public virtual DbSet<MessageTypeTable> MessageTypeTable { get; set; }
        public virtual DbSet<MoneyOrderRule> MoneyOrderRule { get; set; }
        public virtual DbSet<MoneyOrderStep> MoneyOrderStep { get; set; }
        public virtual DbSet<MoneyOrderValueAddedService> MoneyOrderValueAddedService { get; set; }
        public virtual DbSet<MoneyOrderValueAddedServiceSingeItem> MoneyOrderValueAddedServiceSingeItem { get; set; }
        public virtual DbSet<NearProvince> NearProvince { get; set; }
        public virtual DbSet<NearRegion> NearRegion { get; set; }
        public virtual DbSet<Node> Node { get; set; }
        public virtual DbSet<NodeToNode> NodeToNode { get; set; }
        public virtual DbSet<ObjectRef> ObjectRef { get; set; }
        public virtual DbSet<Oe> Oe { get; set; }
        public virtual DbSet<OfflinePos> OfflinePos { get; set; }
        public virtual DbSet<OnlineBatch> OnlineBatch { get; set; }
        public virtual DbSet<OnlineItem> OnlineItem { get; set; }
        public virtual DbSet<OnlineOrder> OnlineOrder { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionAndGroupPermission> PermissionAndGroupPermission { get; set; }
        public virtual DbSet<PermissionGroup> PermissionGroup { get; set; }
        public virtual DbSet<PermissionGroupReportShiftReport> PermissionGroupReportShiftReport { get; set; }
        public virtual DbSet<PermissionReportShiftReport> PermissionReportShiftReport { get; set; }
        public virtual DbSet<PetrolFreightSurchargeRule> PetrolFreightSurchargeRule { get; set; }
        public virtual DbSet<Phase> Phase { get; set; }
        public virtual DbSet<PhaseQualityTarget> PhaseQualityTarget { get; set; }
        public virtual DbSet<Pos> Pos { get; set; }
        public virtual DbSet<Posconfiguration> Posconfiguration { get; set; }
        public virtual DbSet<PosfreightRegion> PosfreightRegion { get; set; }
        public virtual DbSet<Poslevel> Poslevel { get; set; }
        public virtual DbSet<PosprintConfiguration> PosprintConfiguration { get; set; }
        public virtual DbSet<Posservice> Posservice { get; set; }
        public virtual DbSet<PostBag> PostBag { get; set; }
        public virtual DbSet<PostBagLog> PostBagLog { get; set; }
        public virtual DbSet<PostBagType> PostBagType { get; set; }
        public virtual DbSet<PostmanDeliveryRoute> PostmanDeliveryRoute { get; set; }
        public virtual DbSet<Postype> Postype { get; set; }
        public virtual DbSet<Posversion> Posversion { get; set; }
        public virtual DbSet<PrintConfiguration> PrintConfiguration { get; set; }
        public virtual DbSet<PrintedMatter> PrintedMatter { get; set; }
        public virtual DbSet<PrintedMatterMachine> PrintedMatterMachine { get; set; }
        public virtual DbSet<PrintedMatterPhase> PrintedMatterPhase { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<ProvinceFreightRegion> ProvinceFreightRegion { get; set; }
        public virtual DbSet<ProvinceInterconnect> ProvinceInterconnect { get; set; }
        public virtual DbSet<QualityTargetRule> QualityTargetRule { get; set; }
        public virtual DbSet<Range> Range { get; set; }
        public virtual DbSet<RangeCause> RangeCause { get; set; }
        public virtual DbSet<RangeCommodityType> RangeCommodityType { get; set; }
        public virtual DbSet<RangeServiceItemType> RangeServiceItemType { get; set; }
        public virtual DbSet<RangeSolution> RangeSolution { get; set; }
        public virtual DbSet<RangeUndeliveryGuide> RangeUndeliveryGuide { get; set; }
        public virtual DbSet<RangeValueAddedServicePhase> RangeValueAddedServicePhase { get; set; }
        public virtual DbSet<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual DbSet<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual DbSet<ReceiverReason> ReceiverReason { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionInterconnect> RegionInterconnect { get; set; }
        public virtual DbSet<RegionType> RegionType { get; set; }
        public virtual DbSet<RevenueSharing> RevenueSharing { get; set; }
        public virtual DbSet<RevenueSharingItemType> RevenueSharingItemType { get; set; }
        public virtual DbSet<RevenueSharingRule> RevenueSharingRule { get; set; }
        public virtual DbSet<RevenueSharingValueAddedService> RevenueSharingValueAddedService { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleObject> RoleObject { get; set; }
        public virtual DbSet<RolePermission> RolePermission { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesGrantPermission> RolesGrantPermission { get; set; }
        public virtual DbSet<RpAcceptanceDetailReport> RpAcceptanceDetailReport { get; set; }
        public virtual DbSet<RpAcceptanceReports> RpAcceptanceReports { get; set; }
        public virtual DbSet<RpAcceptanceReportsForOther> RpAcceptanceReportsForOther { get; set; }
        public virtual DbSet<RpCustomerAcceptanceReports> RpCustomerAcceptanceReports { get; set; }
        public virtual DbSet<RpCustomerAcceptanceReportsForOther> RpCustomerAcceptanceReportsForOther { get; set; }
        public virtual DbSet<RpDeliveryReports> RpDeliveryReports { get; set; }
        public virtual DbSet<RpObjectParameters> RpObjectParameters { get; set; }
        public virtual DbSet<RpObjectsFillReportsData> RpObjectsFillReportsData { get; set; }
        public virtual DbSet<RpProcessingReports> RpProcessingReports { get; set; }
        public virtual DbSet<RpReportTargetCatalog> RpReportTargetCatalog { get; set; }
        public virtual DbSet<RpReportTargetProperties> RpReportTargetProperties { get; set; }
        public virtual DbSet<RpReportTargetPropertyValues> RpReportTargetPropertyValues { get; set; }
        public virtual DbSet<RpReportTargets> RpReportTargets { get; set; }
        public virtual DbSet<RpTargetValueChanges> RpTargetValueChanges { get; set; }
        public virtual DbSet<RpTransportReports> RpTransportReports { get; set; }
        public virtual DbSet<SaleChannel> SaleChannel { get; set; }
        public virtual DbSet<Section> Section { get; set; }
        public virtual DbSet<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
        public virtual DbSet<SenderInternationalCompensate> SenderInternationalCompensate { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceCommodityType> ServiceCommodityType { get; set; }
        public virtual DbSet<ServiceConfiguration> ServiceConfiguration { get; set; }
        public virtual DbSet<ServiceItemRemaining> ServiceItemRemaining { get; set; }
        public virtual DbSet<ServiceItemType> ServiceItemType { get; set; }
        public virtual DbSet<ServicePhase> ServicePhase { get; set; }
        public virtual DbSet<ServicePosconfiguration> ServicePosconfiguration { get; set; }
        public virtual DbSet<ServicePrintedMatter> ServicePrintedMatter { get; set; }
        public virtual DbSet<ServicePriority> ServicePriority { get; set; }
        public virtual DbSet<ServiceProperty> ServiceProperty { get; set; }
        public virtual DbSet<ServiceSaleChannel> ServiceSaleChannel { get; set; }
        public virtual DbSet<ServiceSupplying> ServiceSupplying { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<ShiftHandover> ShiftHandover { get; set; }
        public virtual DbSet<ShiftHandoverBc37> ShiftHandoverBc37 { get; set; }
        public virtual DbSet<ShiftHandoverItem> ShiftHandoverItem { get; set; }
        public virtual DbSet<ShiftHandoverMailtrip> ShiftHandoverMailtrip { get; set; }
        public virtual DbSet<ShiftHandoverMailtripTransport> ShiftHandoverMailtripTransport { get; set; }
        public virtual DbSet<ShiftHandoverPostBag> ShiftHandoverPostBag { get; set; }
        public virtual DbSet<SlpDeliveryReport> SlpDeliveryReport { get; set; }
        public virtual DbSet<Sms> Sms { get; set; }
        public virtual DbSet<Solution> Solution { get; set; }
        public virtual DbSet<SolutionCustomer> SolutionCustomer { get; set; }
        public virtual DbSet<StampMachine> StampMachine { get; set; }
        public virtual DbSet<StampMachineFeight> StampMachineFeight { get; set; }
        public virtual DbSet<StoreBehavior> StoreBehavior { get; set; }
        public virtual DbSet<StoreDependOn> StoreDependOn { get; set; }
        public virtual DbSet<StoreType> StoreType { get; set; }
        public virtual DbSet<SynchronizationHistory> SynchronizationHistory { get; set; }
        public virtual DbSet<Table> Table { get; set; }
        public virtual DbSet<TargetCataloge> TargetCataloge { get; set; }
        public virtual DbSet<TargetParameters> TargetParameters { get; set; }
        public virtual DbSet<TargetValues> TargetValues { get; set; }
        public virtual DbSet<Targets> Targets { get; set; }
        public virtual DbSet<TraceItem> TraceItem { get; set; }
        public virtual DbSet<TracePostBag> TracePostBag { get; set; }
        public virtual DbSet<TraceTransactionsCollection> TraceTransactionsCollection { get; set; }
        public virtual DbSet<TransactionCollectionChanged> TransactionCollectionChanged { get; set; }
        public virtual DbSet<TransactionsCollection> TransactionsCollection { get; set; }
        public virtual DbSet<TransactionsCollectionDetail> TransactionsCollectionDetail { get; set; }
        public virtual DbSet<TransactionsPayment> TransactionsPayment { get; set; }
        public virtual DbSet<TransactionsPaymentRevert> TransactionsPaymentRevert { get; set; }
        public virtual DbSet<TransactionsReceiver> TransactionsReceiver { get; set; }
        public virtual DbSet<TransactionsReceiverRevert> TransactionsReceiverRevert { get; set; }
        public virtual DbSet<TransitFreight> TransitFreight { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }
        public virtual DbSet<TransportGroup> TransportGroup { get; set; }
        public virtual DbSet<TransportType> TransportType { get; set; }
        public virtual DbSet<UndeliveryGuide> UndeliveryGuide { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }
        public virtual DbSet<UnitType> UnitType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserGroup> UserGroup { get; set; }
        public virtual DbSet<UserTargets> UserTargets { get; set; }
        public virtual DbSet<ValueAddedService> ValueAddedService { get; set; }
        public virtual DbSet<ValueAddedServiceItem> ValueAddedServiceItem { get; set; }
        public virtual DbSet<ValueAddedServiceItemChanged> ValueAddedServiceItemChanged { get; set; }
        public virtual DbSet<ValueAddedServiceItemUnUse> ValueAddedServiceItemUnUse { get; set; }
        public virtual DbSet<ValueAddedServicePhase> ValueAddedServicePhase { get; set; }
        public virtual DbSet<Vasproperty> Vasproperty { get; set; }
        public virtual DbSet<Vasusing> Vasusing { get; set; }
        public virtual DbSet<Version> Version { get; set; }
        public virtual DbSet<WholeQualityTarget> WholeQualityTarget { get; set; }

        // Unable to generate entity type for table 'dbo.tmpDomesticFarRegionFreightStep'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LogTableNew'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.bcn_Commissiontodelivery_SubOffice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.DeleteParameter_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.StoreDependOn_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GetDependOn_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.GetParameter_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Column_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MessageTypeTable_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.MessageType_DeleteBackUp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpMoneyOrderRule'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpMoneyOrderStep'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpMoneyOrderValueAddedService'. Please see the warning messages.
        public BCCPContext(DbContextOptions options):base(options)
        {}
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //     //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BCCP;Trusted_Connection=True;");
        // }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.Property(e => e.Comment).HasMaxLength(1000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Poscode)
                    .IsRequired()
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityLog_ActivityLogType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ActivityLog)
                    .HasForeignKey(d => new { d.Username, d.Poscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ActivityLog_User");
            });

            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.Property(e => e.ActionKeyword)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<Affair>(entity =>
            {
                entity.HasKey(e => new { e.AffairIndex, e.ItemCode })
                    .HasName("PK_Ctin_Affair_NonCluster");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AcceptancePoscode)
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AffairCodstatus).HasColumnName("AffairCODStatus");

                entity.Property(e => e.AffairContent).HasMaxLength(500);

                entity.Property(e => e.AffairDate).HasColumnType("datetime");

                entity.Property(e => e.AffairNumber).HasMaxLength(12);

                entity.Property(e => e.AmountCod).HasColumnName("AmountCOD");

                entity.Property(e => e.AmountCodold).HasColumnName("AmountCODOld");

                entity.Property(e => e.ApprovedContentLevelOne).HasMaxLength(500);

                entity.Property(e => e.ApprovedContentLevelTwo).HasMaxLength(500);

                entity.Property(e => e.ApprovedDateLevelOne).HasColumnType("datetime");

                entity.Property(e => e.ApprovedDateLevelTwo).HasColumnType("datetime");

                entity.Property(e => e.ApprovedPoslevelOne)
                    .HasColumnName("ApprovedPOSLevelOne")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedPoslevelTwo)
                    .HasColumnName("ApprovedPOSLevelTwo")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedUserLevelOne).HasMaxLength(200);

                entity.Property(e => e.ApprovedUserLevelTwo).HasMaxLength(200);

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ClosedPoscode)
                    .HasColumnName("ClosedPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ClosedTime).HasColumnType("datetime");

                entity.Property(e => e.CollectionPerson).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Demonstration).HasMaxLength(255);

                entity.Property(e => e.DistrictNew).HasMaxLength(50);

                entity.Property(e => e.DistrictOld).HasMaxLength(50);

                entity.Property(e => e.FreightCod).HasColumnName("FreightCOD");

                entity.Property(e => e.FreightCoddifference).HasColumnName("FreightCODDifference");

                entity.Property(e => e.FreightCodold).HasColumnName("FreightCODOld");

                entity.Property(e => e.FreightVatcod).HasColumnName("FreightVATCOD");

                entity.Property(e => e.FreightVatcodold).HasColumnName("FreightVATCODOld");

                entity.Property(e => e.InputUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode).HasMaxLength(50);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.PostBagNumber).HasMaxLength(3);

                entity.Property(e => e.Processing).HasMaxLength(50);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ProvinceNew).HasMaxLength(50);

                entity.Property(e => e.ProvinceOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverAddressNew).HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressOld).HasMaxLength(500);

                entity.Property(e => e.ReceiverContact).HasMaxLength(50);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiverFullname).HasMaxLength(100);

                entity.Property(e => e.ReceiverFullnameNew).HasMaxLength(50);

                entity.Property(e => e.ReceiverFullnameOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.ReceiverIdentificationNew).HasMaxLength(50);

                entity.Property(e => e.ReceiverIdentificationOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueCountry).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverPosCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverTaxCode).HasMaxLength(20);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.ReturnPerson).HasMaxLength(50);

                entity.Property(e => e.SenderAddressNew).HasMaxLength(50);

                entity.Property(e => e.SenderAddressOld).HasMaxLength(50);

                entity.Property(e => e.ToPoscode).HasMaxLength(6);

                entity.Property(e => e.TotalFreightCancelCod).HasColumnName("TotalFreightCancelCOD");

                entity.Property(e => e.TotalFreightEditCod).HasColumnName("TotalFreightEditCOD");

                entity.Property(e => e.TotalFreightVatold).HasColumnName("TotalFreightVATOld");

                entity.Property(e => e.TransactionsPaymentCode).HasMaxLength(50);

                entity.Property(e => e.TransactionsReceiverCode).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Affair)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_Affair_Item");
            });

            modelBuilder.Entity<AffairDetailItem>(entity =>
            {
                entity.HasKey(e => new { e.AffairIndex, e.ItemIndex, e.ItemCode })
                    .HasName("PK_AffairDetailItem");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChemicalItemName).HasMaxLength(500);

                entity.Property(e => e.ChemicalItemNameOld).HasMaxLength(500);

                entity.Property(e => e.ChemicalName).HasMaxLength(500);

                entity.Property(e => e.ChemicalNameOld).HasMaxLength(500);

                entity.Property(e => e.ChemicalTypeCode).HasMaxLength(5);

                entity.Property(e => e.ChemicalTypeCodeOld).HasMaxLength(5);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailItemName).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalCountryCode).HasMaxLength(3);

                entity.Property(e => e.OriginalCountryCodeOld).HasMaxLength(3);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TaxCodeOld).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.Property(e => e.UnitOld).HasMaxLength(50);
            });

            modelBuilder.Entity<AffairHistory>(entity =>
            {
                entity.Property(e => e.AffairHistoryId).ValueGeneratedNever();

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HistoryContent).HasMaxLength(1000);

                entity.Property(e => e.HistoryCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryCreatedPos)
                    .HasColumnName("HistoryCreatedPOS")
                    .HasMaxLength(200);

                entity.Property(e => e.HistoryCreator).HasMaxLength(100);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<AffairItem>(entity =>
            {
                entity.HasKey(e => new { e.AffairIndex, e.ItemCode })
                    .HasName("PK_AffairItem");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalPaymentFreightDiscountVat).HasColumnName("OriginalPaymentFreightDiscountVAT");

                entity.Property(e => e.OriginalPaymentFreightVat).HasColumnName("OriginalPaymentFreightVAT");

                entity.Property(e => e.OriginalRemainingFreightDiscountVat).HasColumnName("OriginalRemainingFreightDiscountVAT");

                entity.Property(e => e.OriginalRemainingFreightVat).HasColumnName("OriginalRemainingFreightVAT");

                entity.Property(e => e.OriginalTotalFreightDiscountVat).HasColumnName("OriginalTotalFreightDiscountVAT");

                entity.Property(e => e.OriginalTotalFreightVat).HasColumnName("OriginalTotalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.PaymentFreightDiscountVat).HasColumnName("PaymentFreightDiscountVAT");

                entity.Property(e => e.PaymentFreightVat).HasColumnName("PaymentFreightVAT");

                entity.Property(e => e.RemainingFreightDiscountVat).HasColumnName("RemainingFreightDiscountVAT");

                entity.Property(e => e.RemainingFreightVat).HasColumnName("RemainingFreightVAT");

                entity.Property(e => e.TotalFreightDiscountVat).HasColumnName("TotalFreightDiscountVAT");

                entity.Property(e => e.TotalFreightVat).HasColumnName("TotalFreightVAT");

                entity.Property(e => e.TotalFreightVatold).HasColumnName("TotalFreightVATOld");

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");
            });

            modelBuilder.Entity<AffairItemVaspropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.PropertyCode, e.ValueAddedServiceCode, e.AffairIndex })
                    .HasName("PK_AffairItemVASPropertyValue_1");

                entity.ToTable("AffairItemVASPropertyValue");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(500);
            });

            modelBuilder.Entity<AffairResponse>(entity =>
            {
                entity.Property(e => e.AffairResponseId)
                    .HasColumnName("AffairResponseID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AffairProcess).HasMaxLength(250);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Demonstration)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Posresponse)
                    .HasColumnName("POSResponse")
                    .HasMaxLength(6);

                entity.Property(e => e.UserResponse).HasMaxLength(50);
            });

            modelBuilder.Entity<AffairTransactionsCollection>(entity =>
            {
                entity.HasKey(e => e.AffairTransactionsCollection1)
                    .HasName("PK_AffairTransactionsCollection");

                entity.Property(e => e.AffairTransactionsCollection1)
                    .HasColumnName("AffairTransactionsCollection")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiverCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificatePlace).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.TransactionsCollectionChannel).HasMaxLength(50);

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.TransactionsCollectionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AffairTransport>(entity =>
            {
                entity.HasKey(e => new { e.AffairIndex, e.FromPoscode })
                    .HasName("PK_AffairTransport");

                entity.Property(e => e.AffairIndex).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.AffairContent).HasMaxLength(3000);

                entity.Property(e => e.AffairDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InputUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode).HasMaxLength(50);

                entity.Property(e => e.MailRouteScheduleCode).HasMaxLength(50);

                entity.Property(e => e.ProcessDate).HasColumnType("datetime");

                entity.Property(e => e.TransportCode).HasMaxLength(50);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportNumber).HasMaxLength(3);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AffairValue>(entity =>
            {
                entity.HasKey(e => e.AffairId)
                    .HasName("PK_AffairValue");

                entity.Property(e => e.AffairId)
                    .HasColumnName("AffairID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AffairName).HasMaxLength(50);
            });

            modelBuilder.Entity<AffairVasitem>(entity =>
            {
                entity.HasKey(e => new { e.AffairIndex, e.ServiceCode, e.ValueAddedServiceCode, e.ItemCode })
                    .HasName("PK_AffairVASItem");

                entity.ToTable("AffairVASItem");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FreightVat).HasColumnName("FreightVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalFreightVat).HasColumnName("OriginalFreightVAT");

                entity.Property(e => e.OriginalSubFreightVat).HasColumnName("OriginalSubFreightVAT");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.SubFreightVat).HasColumnName("SubFreightVAT");
            });

            modelBuilder.Entity<ApplicationVersion>(entity =>
            {
                entity.HasKey(e => e.ApplicationVersionNumber)
                    .HasName("PK_ApplicationVersion");

                entity.Property(e => e.ApplicationVersionNumber).HasMaxLength(10);

                entity.Property(e => e.DateApplied).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RequiredDbVersionNumber)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.VersionChanges).HasMaxLength(500);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.HasKey(e => e.BatchCode)
                    .HasName("PK_Batch");

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.OtherAttachedInfor).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<BatchPos>(entity =>
            {
                entity.HasKey(e => e.BatchCode)
                    .HasName("PK_BatchPOS");

                entity.ToTable("BatchPOS");

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.BatchPos)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_BatchPOS_POS");
            });

            modelBuilder.Entity<Bc37>(entity =>
            {
                entity.HasKey(e => new { e.Bc37index, e.FromPoscode, e.ToPoscode, e.TransportTypeCode, e.Bc37date })
                    .HasName("PK_BC37");

                entity.ToTable("BC37");

                entity.HasIndex(e => new { e.Bc37index, e.ToPoscode, e.FromPoscode, e.Bc37date })
                    .HasName("_dta_index_BC37_5_917578307__K3_K2_K6_1");

                entity.HasIndex(e => new { e.Bc37code, e.Status, e.TotalOtherPostBag, e.TotalPhbcpostBag, e.TotalWeightOtherPostBag, e.TotalWeightPhbcpostBag, e.FromPoscode, e.ToPoscode, e.Bc37date, e.Bc37index, e.TransportTypeCode })
                    .HasName("_dta_index_BC37_6_949578421__K2_K3_K6_K1_K4_5_11_19_20_21_22");

                entity.HasIndex(e => new { e.Bc37code, e.Status, e.TotalOtherPostBag, e.TotalPhbcpostBag, e.TotalWeightOtherPostBag, e.TotalWeightPhbcpostBag, e.ToPoscode, e.Bc37date, e.Bc37index, e.FromPoscode, e.TransportTypeCode })
                    .HasName("_dta_index_BC37_6_949578421__K3_K6_K1_K2_K4_5_11_19_20_21_22");

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37code)
                    .HasColumnName("BC37Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmPoscode)
                    .HasColumnName("ConfirmPOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmUser).HasMaxLength(50);

                entity.Property(e => e.CreatePoscode)
                    .HasColumnName("CreatePOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.MailRouteFromPoscode)
                    .HasColumnName("MailRouteFromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailRouteScheduleCode).HasMaxLength(6);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.TotalPhbcpostBag).HasColumnName("TotalPHBCPostBag");

                entity.Property(e => e.TotalWeightPhbcpostBag).HasColumnName("TotalWeightPHBCPostBag");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Bc37route>(entity =>
            {
                entity.HasKey(e => new { e.FromPoscode, e.ToPoscode, e.AcceptedPoscode })
                    .HasName("PK_BC37Route");

                entity.ToTable("BC37Route");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AcceptedPoscode)
                    .HasColumnName("AcceptedPOSCode")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<Bc37routeType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_BC37RouteType");

                entity.ToTable("BC37RouteType");

                entity.Property(e => e.TypeId)
                    .HasColumnName("TypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Bc43>(entity =>
            {
                entity.HasKey(e => new { e.Bc43code, e.FromPosCode })
                    .HasName("PK_BC43_1");

                entity.ToTable("BC43");

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromPosCode).HasMaxLength(6);

                entity.Property(e => e.AttachmentFileName).HasMaxLength(500);

                entity.Property(e => e.Bc37code)
                    .HasColumnName("BC37Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37fromPosCode)
                    .HasColumnName("BC37FromPosCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.Bc37toPosCode)
                    .HasColumnName("BC37ToPosCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc37transportTypeCode)
                    .HasColumnName("BC37TransportTypeCode")
                    .HasMaxLength(1);

                entity.Property(e => e.Bc43content).HasColumnName("BC43Content");

                entity.Property(e => e.Bc43creator)
                    .HasColumnName("BC43Creator")
                    .HasMaxLength(200);

                entity.Property(e => e.Bc43leaderOfPos)
                    .HasColumnName("BC43LeaderOfPos")
                    .HasMaxLength(200);

                entity.Property(e => e.Bc43replyFromReceptionPos)
                    .HasColumnName("BC43ReplyFromReceptionPOS")
                    .HasMaxLength(1000);

                entity.Property(e => e.Bc43subType).HasColumnName("BC43SubType");

                entity.Property(e => e.Bc43type).HasColumnName("BC43Type");

                entity.Property(e => e.Bc43viewPos)
                    .HasColumnName("BC43ViewPOS")
                    .HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDateBigCustomer).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailTripDate).HasColumnType("datetime");

                entity.Property(e => e.MailTripDestinationCode).HasMaxLength(6);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.MailTripServiceCode).HasMaxLength(2);

                entity.Property(e => e.MailTripStartingCode).HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.MailTripYear).HasMaxLength(8);

                entity.Property(e => e.ReasonCreateBc43)
                    .HasColumnName("ReasonCreateBC43")
                    .HasMaxLength(2000);

                entity.HasOne(d => d.Bc43typeNavigation)
                    .WithMany(p => p.Bc43)
                    .HasForeignKey(d => d.Bc43type)
                    .HasConstraintName("FK_BC43_BC43Type");
            });

            modelBuilder.Entity<Bc43affair>(entity =>
            {
                entity.HasKey(e => new { e.Bc43code, e.FromPosCode, e.ToPosCode })
                    .HasName("PK_BC43Affair");

                entity.ToTable("BC43Affair");

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromPosCode).HasMaxLength(6);

                entity.Property(e => e.ToPosCode).HasMaxLength(6);

                entity.Property(e => e.ClosingDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LeaderOfToPosCode).HasMaxLength(200);

                entity.Property(e => e.ReplyDate).HasColumnType("datetime");

                entity.Property(e => e.ReplyPersonName).HasMaxLength(200);

                entity.Property(e => e.ResolveAffairPosCode).HasMaxLength(8);

                entity.HasOne(d => d.Bc43)
                    .WithMany(p => p.Bc43affair)
                    .HasForeignKey(d => new { d.Bc43code, d.FromPosCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_BC43Affair_BC43");
            });

            modelBuilder.Entity<Bc43dispatch>(entity =>
            {
                entity.HasKey(e => new { e.Bc43code, e.FromPosCode, e.ToPosCode, e.PostBagIndex, e.PostBagFromPosCode, e.PostBagToPosCode, e.PostBagMailTripType, e.PostBagServiceCode, e.PostBagYear, e.PostBagMailTripNumber, e.ItemCode })
                    .HasName("PK_BC43Dispatch");

                entity.ToTable("BC43Dispatch");

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromPosCode).HasMaxLength(6);

                entity.Property(e => e.ToPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagFromPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagToPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagMailTripType).HasMaxLength(1);

                entity.Property(e => e.PostBagServiceCode).HasMaxLength(2);

                entity.Property(e => e.PostBagYear).HasMaxLength(8);

                entity.Property(e => e.PostBagMailTripNumber).HasMaxLength(4);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AcceptancePoscode)
                    .IsRequired()
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AdviceOfReceiptCode).HasMaxLength(13);

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.Bc16index).HasColumnName("BC16Index");

                entity.Property(e => e.CertificateNumber).HasMaxLength(50);

                entity.Property(e => e.CheckContentOnDeliveryCode).HasMaxLength(13);

                entity.Property(e => e.CheckSum).HasMaxLength(1);

                entity.Property(e => e.Codaddress)
                    .HasColumnName("CODAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Codpayment).HasColumnName("CODPayment");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccountNo).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.CustomerGroupCode).HasMaxLength(20);

                entity.Property(e => e.DataCode).HasMaxLength(50);

                entity.Property(e => e.DecisionDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionNo).HasMaxLength(500);

                entity.Property(e => e.DestinationPoscode)
                    .HasColumnName("DestinationPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeRateCode).HasMaxLength(50);

                entity.Property(e => e.ExecuteOrder).HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.ItemCodeCorrect).HasMaxLength(13);

                entity.Property(e => e.ItemNumber).HasMaxLength(50);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.OriginalPaymentFreightDiscountVat).HasColumnName("OriginalPaymentFreightDiscountVAT");

                entity.Property(e => e.OriginalPaymentFreightVat).HasColumnName("OriginalPaymentFreightVAT");

                entity.Property(e => e.OriginalRemainingFreightDiscountVat).HasColumnName("OriginalRemainingFreightDiscountVAT");

                entity.Property(e => e.OriginalRemainingFreightVat).HasColumnName("OriginalRemainingFreightVAT");

                entity.Property(e => e.OriginalTotalFreightDiscountVat).HasColumnName("OriginalTotalFreightDiscountVAT");

                entity.Property(e => e.OriginalTotalFreightVat).HasColumnName("OriginalTotalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.OtherAttachedInfor).HasMaxLength(100);

                entity.Property(e => e.PaymentFreightDiscountVat).HasColumnName("PaymentFreightDiscountVAT");

                entity.Property(e => e.PaymentFreightVat).HasColumnName("PaymentFreightVAT");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverCommuneCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverContact).HasMaxLength(50);

                entity.Property(e => e.ReceiverCustomReference).HasMaxLength(500);

                entity.Property(e => e.ReceiverDistrictCode).HasMaxLength(4);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiverFax).HasMaxLength(15);

                entity.Property(e => e.ReceiverFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueCountry).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverJob).HasMaxLength(500);

                entity.Property(e => e.ReceiverMobile).HasMaxLength(15);

                entity.Property(e => e.ReceiverTaxCode).HasMaxLength(20);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.RemainingFreightDiscountVat).HasColumnName("RemainingFreightDiscountVAT");

                entity.Property(e => e.RemainingFreightVat).HasColumnName("RemainingFreightVAT");

                entity.Property(e => e.ReturnBeforeDate).HasColumnType("datetime");

                entity.Property(e => e.SectionCode).HasMaxLength(3);

                entity.Property(e => e.SenderAddress).HasMaxLength(500);

                entity.Property(e => e.SenderAddressCode).HasMaxLength(6);

                entity.Property(e => e.SenderCustomReference).HasMaxLength(500);

                entity.Property(e => e.SenderDistrictCode).HasMaxLength(4);

                entity.Property(e => e.SenderEmail).HasMaxLength(50);

                entity.Property(e => e.SenderFax).HasMaxLength(15);

                entity.Property(e => e.SenderFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SenderIdentification).HasMaxLength(50);

                entity.Property(e => e.SenderIssueCountry).HasMaxLength(50);

                entity.Property(e => e.SenderIssueDate).HasColumnType("datetime");

                entity.Property(e => e.SenderJob).HasMaxLength(500);

                entity.Property(e => e.SenderMobile).HasMaxLength(15);

                entity.Property(e => e.SenderTaxCode).HasMaxLength(20);

                entity.Property(e => e.SenderTel).HasMaxLength(15);

                entity.Property(e => e.SendingContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.TotalFreightDiscountVat).HasColumnName("TotalFreightDiscountVAT");

                entity.Property(e => e.TotalFreightVat).HasColumnName("TotalFreightVAT");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.Property(e => e.UndeliverableReason).HasMaxLength(500);

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");
            });

            modelBuilder.Entity<Bc43postBag>(entity =>
            {
                entity.HasKey(e => new { e.Bc43code, e.FromPosCode, e.ToPosCode, e.PostBagIndex, e.PostBagFromPosCode, e.PostBagToPosCode, e.PostBagMailTripType, e.PostBagServiceCode, e.PostBagYear, e.PostBagMailTripNumber, e.PostBagCode })
                    .HasName("PK_BC43PostBag");

                entity.ToTable("BC43PostBag");

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromPosCode).HasMaxLength(6);

                entity.Property(e => e.ToPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagFromPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagToPosCode).HasMaxLength(6);

                entity.Property(e => e.PostBagMailTripType).HasMaxLength(1);

                entity.Property(e => e.PostBagServiceCode).HasMaxLength(2);

                entity.Property(e => e.PostBagYear).HasMaxLength(8);

                entity.Property(e => e.PostBagMailTripNumber).HasMaxLength(4);

                entity.Property(e => e.PostBagCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCodeCorrect).HasMaxLength(13);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bc43type>(entity =>
            {
                entity.HasKey(e => e.Bc43type1)
                    .HasName("PK_BC43Type");

                entity.ToTable("BC43Type");

                entity.Property(e => e.Bc43type1)
                    .HasColumnName("BC43Type")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bc43category).HasColumnName("BC43Category");

                entity.Property(e => e.Bc43description)
                    .HasColumnName("BC43Description")
                    .HasMaxLength(500);

                entity.Property(e => e.Bc43typeName)
                    .IsRequired()
                    .HasColumnName("BC43TypeName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BcnCommissiontodelivery>(entity =>
            {
                entity.ToTable("bcn_commissiontodelivery");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmsValue).HasColumnName("Ems_Value");

                entity.Property(e => e.EmsValueTotal).HasColumnName("EMS_Value_Total");

                entity.Property(e => e.ItemTypeCode).HasColumnType("nchar(2)");

                entity.Property(e => e.Vasicode)
                    .HasColumnName("VASICode")
                    .HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<BcnCommissiontodeliveryLevelWeight>(entity =>
            {
                entity.HasKey(e => e.Levelweight)
                    .HasName("PK_bcn_LevelWeight");

                entity.ToTable("bcn_Commissiontodelivery_LevelWeight");
            });

            modelBuilder.Entity<BcnserviceList>(entity =>
            {
                entity.ToTable("BCNServiceList");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrentIndex).HasColumnType("char(10)");

                entity.Property(e => e.CurrentIndexOrder).HasColumnType("char(10)");

                entity.Property(e => e.CurrentIndexSort).HasColumnType("char(10)");

                entity.Property(e => e.FatherId).HasColumnName("FatherID");

                entity.Property(e => e.ItemTypeCode).HasMaxLength(10);

                entity.Property(e => e.Level1).HasColumnName("LEVEL1");

                entity.Property(e => e.Level3).HasColumnName("LEVEL3");

                entity.Property(e => e.LevelValue).HasMaxLength(10);

                entity.Property(e => e.LevelValueName).HasMaxLength(30);

                entity.Property(e => e.ServiceCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCodeName).HasMaxLength(30);

                entity.Property(e => e.ServiceName).HasMaxLength(150);

                entity.Property(e => e.ServiceNameCombobox).HasMaxLength(150);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(20);

                entity.Property(e => e.ValueAddedServiceCodeRef).HasMaxLength(20);
            });

            modelBuilder.Entity<Bd21affairResponse>(entity =>
            {
                entity.HasKey(e => e.AffairResponseNumber)
                    .HasName("PK_AffairResponse");

                entity.ToTable("BD21AffairResponse");

                entity.Property(e => e.AffairResponseNumber).HasMaxLength(12);

                entity.Property(e => e.AffairResultContent).HasMaxLength(1000);

                entity.Property(e => e.Answer).HasMaxLength(2000);

                entity.Property(e => e.AnswerAtRelatePos).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.AnswerUser).HasMaxLength(50);

                entity.Property(e => e.AttachmentFile).HasMaxLength(500);

                entity.Property(e => e.AttachmentFileReply).HasMaxLength(1000);

                entity.Property(e => e.Bc43code)
                    .IsRequired()
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.Bd10fromPoscode)
                    .IsRequired()
                    .HasColumnName("BD10FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FromPoscode)
                    .IsRequired()
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OtherBd10code)
                    .HasColumnName("OtherBD10Code")
                    .HasMaxLength(500);

                entity.Property(e => e.Posorder).HasColumnName("POSOrder");

                entity.Property(e => e.Question).HasMaxLength(2000);

                entity.Property(e => e.ReasonNotAccept).HasMaxLength(500);

                entity.Property(e => e.ReceivingTime).HasColumnType("datetime");

                entity.Property(e => e.ReceivingUser).HasMaxLength(50);

                entity.Property(e => e.ResponseDateExpired).HasColumnType("datetime");

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.SendingUser).HasMaxLength(50);

                entity.Property(e => e.SentBackTime).HasColumnType("datetime");

                entity.Property(e => e.ToPoscode)
                    .IsRequired()
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.Bc43)
                    .WithMany(p => p.Bd21affairResponse)
                    .HasForeignKey(d => new { d.Bc43code, d.FromPoscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AffairResponse_BC43");
            });

            modelBuilder.Entity<Bd21disscusion>(entity =>
            {
                entity.HasKey(e => new { e.CreatedDate, e.MailtripPos, e.Bc43code, e.FromPosCode })
                    .HasName("PK_[Message");

                entity.ToTable("BD21Disscusion");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MailtripPos)
                    .HasColumnName("MailtripPOS")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc43code)
                    .HasColumnName("BC43Code")
                    .HasMaxLength(50);

                entity.Property(e => e.FromPosCode).HasMaxLength(6);

                entity.Property(e => e.AttachmentFileName).HasMaxLength(500);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DisscusionContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.ReplyUser).HasMaxLength(100);
            });

            modelBuilder.Entity<BusinessDomain>(entity =>
            {
                entity.HasKey(e => e.BusinessDomainCode)
                    .HasName("PK_BusinessDomain");

                entity.Property(e => e.BusinessDomainCode).HasMaxLength(5);

                entity.Property(e => e.BusinessDomainName).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => new { e.CategoryCode, e.ServiceCode })
                    .HasName("PK_Category");

                entity.Property(e => e.CategoryCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Cause>(entity =>
            {
                entity.HasKey(e => e.CauseCode)
                    .HasName("PK_Cause");

                entity.Property(e => e.CauseCode).HasMaxLength(2);

                entity.Property(e => e.EnglishCauseName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VietnameseCauseName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CauseCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CauseCode, e.CustomerCode })
                    .HasName("PK_CauseCustomer");

                entity.Property(e => e.CauseCode).HasMaxLength(2);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.HasOne(d => d.CauseCodeNavigation)
                    .WithMany(p => p.CauseCustomer)
                    .HasForeignKey(d => d.CauseCode)
                    .HasConstraintName("FK_CauseCustomer_Cause");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.CauseCustomer)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CauseCustomer_Customer");
            });

            modelBuilder.Entity<CauseSolution>(entity =>
            {
                entity.HasKey(e => new { e.CauseCode, e.SolutionCode })
                    .HasName("PK_CauseSolution");

                entity.Property(e => e.CauseCode).HasMaxLength(2);

                entity.Property(e => e.SolutionCode).HasMaxLength(2);

                entity.HasOne(d => d.CauseCodeNavigation)
                    .WithMany(p => p.CauseSolution)
                    .HasForeignKey(d => d.CauseCode)
                    .HasConstraintName("FK_CauseSolution_Cause");

                entity.HasOne(d => d.SolutionCodeNavigation)
                    .WithMany(p => p.CauseSolution)
                    .HasForeignKey(d => d.SolutionCode)
                    .HasConstraintName("FK_CauseSolution_Solution");
            });

            modelBuilder.Entity<ChangeReason>(entity =>
            {
                entity.HasKey(e => e.ChangeReasonCode)
                    .HasName("PK_ChangeReason");

                entity.Property(e => e.ChangeReasonCode).ValueGeneratedNever();

                entity.Property(e => e.ChangeReasonName).HasMaxLength(200);
            });

            modelBuilder.Entity<ChangedItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ItemCodeOld })
                    .HasName("PK_ChangedItem");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ItemCodeOld).HasMaxLength(13);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeOldNavigation)
                    .WithMany(p => p.ChangedItem)
                    .HasForeignKey(d => d.ItemCodeOld)
                    .HasConstraintName("FK_ChangedItem_Item");
            });

            modelBuilder.Entity<ChemicalType>(entity =>
            {
                entity.HasKey(e => e.ChemicalTypeCode)
                    .HasName("PK_ChemicalType");

                entity.Property(e => e.ChemicalTypeCode).HasMaxLength(5);

                entity.Property(e => e.ChemicalTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.HasKey(e => new { e.ClaimNumber, e.RecevingClaimPoscode })
                    .HasName("PK_Claim");

                entity.HasIndex(e => e.ClaimItemCode)
                    .HasName("IX_Claim_ItemCode");

                entity.HasIndex(e => e.ClaimTime)
                    .HasName("IX_Claim_ClainTime");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Claim_Status");

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AcceptancePoscode)
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AttachmentFileName).HasMaxLength(500);

                entity.Property(e => e.ClaimContent).HasMaxLength(2000);

                entity.Property(e => e.ClaimItemCode).HasMaxLength(13);

                entity.Property(e => e.ClaimPersonAddress).HasMaxLength(200);

                entity.Property(e => e.ClaimPersonEmail).HasMaxLength(50);

                entity.Property(e => e.ClaimPersonName).HasMaxLength(50);

                entity.Property(e => e.ClaimPersonTel).HasMaxLength(50);

                entity.Property(e => e.ClaimPriorityCode).HasMaxLength(5);

                entity.Property(e => e.ClaimReceivingTime).HasColumnType("datetime");

                entity.Property(e => e.ClaimTime).HasColumnType("datetime");

                entity.Property(e => e.ClaimTypeCode).HasMaxLength(5);

                entity.Property(e => e.ClosingTime).HasColumnType("datetime");

                entity.Property(e => e.ClosingUser).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HeadOfRecevingUnit).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.ClaimPriorityCodeNavigation)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ClaimPriorityCode)
                    .HasConstraintName("FK_Claim_ClaimPriority");

                entity.HasOne(d => d.ClaimTypeCodeNavigation)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ClaimTypeCode)
                    .HasConstraintName("FK_Claim_ClaimType");

                entity.HasOne(d => d.RecevingClaimPoscodeNavigation)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.RecevingClaimPoscode)
                    .HasConstraintName("FK_Claim_POS");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.Claim)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_Claim_Service");
            });

            modelBuilder.Entity<ClaimItem>(entity =>
            {
                entity.HasKey(e => new { e.ClaimNumber, e.RecevingClaimPoscode, e.ItemCode })
                    .HasName("PK_ClaimItem");

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ClaimItem)
                    .HasForeignKey(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Item");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimItem)
                    .HasForeignKey(d => new { d.ClaimNumber, d.RecevingClaimPoscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Claim");
            });

            modelBuilder.Entity<ClaimPriority>(entity =>
            {
                entity.HasKey(e => e.ClaimPriorityCode)
                    .HasName("PK_ClaimPriority");

                entity.Property(e => e.ClaimPriorityCode).HasMaxLength(5);

                entity.Property(e => e.ClaimPriorityName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ClaimResponse>(entity =>
            {
                entity.HasKey(e => new { e.ClaimResponseNumber, e.ReceivingClaimPoscode, e.FromPoscode, e.ToPoscode, e.ClaimNumber })
                    .HasName("PK_ClaimResponse");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_ClaimResponse_Status");

                entity.Property(e => e.ReceivingClaimPoscode)
                    .HasColumnName("ReceivingClaimPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Answer).HasMaxLength(2000);

                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.AnswerRelatePos).HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Question).HasMaxLength(2000);

                entity.Property(e => e.ReceivingTime).HasColumnType("datetime");

                entity.Property(e => e.ReceivingUser).HasMaxLength(50);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.SendingUser).HasMaxLength(50);

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ClaimResponse)
                    .HasForeignKey(d => new { d.ClaimNumber, d.ReceivingClaimPoscode })
                    .HasConstraintName("FK_ClaimResponse_Claim");
            });

            modelBuilder.Entity<ClaimType>(entity =>
            {
                entity.HasKey(e => e.ClaimTypeCode)
                    .HasName("PK_ClaimType");

                entity.Property(e => e.ClaimTypeCode).HasMaxLength(5);

                entity.Property(e => e.ClaimTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<ClientReservation>(entity =>
            {
                entity.Property(e => e.ClientReservationId).ValueGeneratedNever();

                entity.Property(e => e.ReservationTime).HasColumnType("datetime");

                entity.Property(e => e.SessionId).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<CollectionFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.CollectionFreightStepCode, e.ServiceCode })
                    .HasName("PK_CollectionFreightStep");

                entity.Property(e => e.CollectionFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.CollectionFreightStep)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_CollectionFreightStep_Service");
            });

            modelBuilder.Entity<Column>(entity =>
            {
                entity.HasKey(e => new { e.ColumnName, e.TableName })
                    .HasName("PK_Column_1");

                entity.HasIndex(e => new { e.ColumnName, e.DataType, e.InPrimaryKey, e.IsIdentity, e.IsNullable, e.IsUnique, e.TableName })
                    .HasName("_dta_index_Column_5_914102297__K2_1_3_4_5_6_7");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TableNameNavigation)
                    .WithMany(p => p.Column)
                    .HasForeignKey(d => d.TableName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Column_Table");
            });

            modelBuilder.Entity<CommodityType>(entity =>
            {
                entity.HasKey(e => e.CommodityTypeCode)
                    .HasName("PK_CommodityType");

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.CommodityTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Commune>(entity =>
            {
                entity.HasKey(e => e.CommuneCode)
                    .HasName("PK_Commune");

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.Property(e => e.CommuneName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.Commune)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Commune_District");
            });

            modelBuilder.Entity<CommuneFreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.CommuneCode, e.DomesticFreightRuleCode })
                    .HasName("PK_CommuneFreightRegion");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.CommuneFreightRegion)
                    .HasForeignKey(d => d.CommuneCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommuneFreightRegion_Commune");

                entity.HasOne(d => d.FreightRegion)
                    .WithMany(p => p.CommuneFreightRegion)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommuneFreightRegion_FreightRegion");
            });

            modelBuilder.Entity<CommuneFreightRegionDeliveryAddress>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.DomesticFreightRuleCode, e.CommuneCode })
                    .HasName("PK_CommuneFreightRegionDeliveryAddress");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.CommuneFreightRegionDeliveryAddress)
                    .HasForeignKey(d => d.CommuneCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommuneFreightRegionDeliveryAddress_Commune");

                entity.HasOne(d => d.FreightRegionDeliveryAddress)
                    .WithMany(p => p.CommuneFreightRegionDeliveryAddress)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CommuneFreightRegionDeliveryAddress_FreightRegionDeliveryAddress");
            });

            modelBuilder.Entity<CommunicationConfig>(entity =>
            {
                entity.HasKey(e => e.ConfigKey)
                    .HasName("PK_CommunicationConfig");

                entity.Property(e => e.ConfigKey).HasMaxLength(50);

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);
            });

            modelBuilder.Entity<CompensateCategory>(entity =>
            {
                entity.HasKey(e => e.CompensateCategoryCode)
                    .HasName("PK_CompensateCategory");

                entity.Property(e => e.CompensateCategoryCode).HasMaxLength(10);

                entity.Property(e => e.CompensateCategoryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(300);
            });

            modelBuilder.Entity<CompensateRate>(entity =>
            {
                entity.HasKey(e => new { e.CompensateRateCode, e.ItemTypeCode, e.ServiceCode })
                    .HasName("PK_CompensateRate");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_CompensateRate_ValueDate");

                entity.Property(e => e.CompensateRateCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceItemType)
                    .WithMany(p => p.CompensateRate)
                    .HasForeignKey(d => new { d.ServiceCode, d.ItemTypeCode })
                    .HasConstraintName("FK_CompensateRate_ServiceItemType");
            });

            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.ConfigCode)
                    .HasName("PK_Configuration");

                entity.Property(e => e.ConfigCode).HasMaxLength(50);

                entity.Property(e => e.ConfigName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasMaxLength(50);
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.HasKey(e => e.ContinentCode)
                    .HasName("PK_Continent");

                entity.Property(e => e.ContinentCode).HasMaxLength(2);

                entity.Property(e => e.ContinentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<Controls>(entity =>
            {
                entity.HasKey(e => new { e.ControlId, e.ObjectRefId })
                    .HasName("PK_Controls");

                entity.Property(e => e.ControlName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ControlType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasKey(e => new { e.CounterCode, e.Poscode })
                    .HasName("PK_Counter");

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CounterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Counter)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_Counter_POS");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryCode)
                    .HasName("PK_Country");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.ContinentCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.IsPostalParcels).HasColumnName("isPostalParcels");

                entity.Property(e => e.IsPrintedCn23).HasColumnName("isPrintedCN23");

                entity.HasOne(d => d.ContinentCodeNavigation)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.ContinentCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Country_Continent");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerCode)
                    .HasName("PK_Customer_1");

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(128);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.IdentificationNumber).HasMaxLength(20);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(100);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TaxCode).HasMaxLength(20);

                entity.Property(e => e.Tel).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomerBusinessDomain>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.CustomerCode, e.BusinessDomainCode })
                    .HasName("PK_CustomerBusinessDomain");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CustomerCode).HasMaxLength(14);

                entity.Property(e => e.BusinessDomainCode).HasMaxLength(5);

                entity.HasOne(d => d.BusinessDomainCodeNavigation)
                    .WithMany(p => p.CustomerBusinessDomain)
                    .HasForeignKey(d => d.BusinessDomainCode)
                    .HasConstraintName("FK_CustomerBusinessDomain_BusinessDomain");
            });

            modelBuilder.Entity<CustomerContract>(entity =>
            {
                entity.HasKey(e => e.ContractNumber)
                    .HasName("PK_CustomerContract");

                entity.Property(e => e.ContractNumber).HasMaxLength(60);

                entity.Property(e => e.CustomerAddress).HasMaxLength(500);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(17);

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAccount).HasMaxLength(50);

                entity.Property(e => e.PaymentAddress).HasMaxLength(500);

                entity.Property(e => e.PaymentBank).HasMaxLength(100);

                entity.Property(e => e.PaymentBranch).HasMaxLength(100);

                entity.Property(e => e.PaymentFrequency).HasMaxLength(50);

                entity.Property(e => e.PaymentFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.SenderAddress).HasMaxLength(500);

                entity.Property(e => e.SignDate).HasColumnType("datetime");

                entity.Property(e => e.ThirdPartyCompanyName).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(250);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.CustomerContract)
                    .HasForeignKey(d => d.CustomerCode)
                    .HasConstraintName("FK_CustomerContract_Customer");
            });

            modelBuilder.Entity<CustomerGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupCode)
                    .HasName("PK_CustomerGroup");

                entity.Property(e => e.CustomerGroupCode).HasMaxLength(20);

                entity.Property(e => e.CustomerGroupContent).HasMaxLength(500);

                entity.Property(e => e.CustomerGroupName).HasMaxLength(100);

                entity.Property(e => e.DeliveryRequirement).HasMaxLength(1000);
            });

            modelBuilder.Entity<DbVersion>(entity =>
            {
                entity.HasKey(e => e.DbVersionNumber)
                    .HasName("PK_DbVersion");

                entity.Property(e => e.DbVersionNumber).HasMaxLength(10);

                entity.Property(e => e.DateApplied).HasColumnType("datetime");

                entity.Property(e => e.DbChanges).HasMaxLength(500);

                entity.Property(e => e.ScriptName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Deduction>(entity =>
            {
                entity.HasKey(e => e.DeductionCode)
                    .HasName("PK_Deduction");

                entity.Property(e => e.DeductionCode).HasMaxLength(10);

                entity.Property(e => e.DeductionName).HasMaxLength(150);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.Deduction)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_Deduction_Service");
            });

            modelBuilder.Entity<DeductionDetail>(entity =>
            {
                entity.HasKey(e => e.DeductionDetailCode)
                    .HasName("PK_DeductionDetail");

                entity.Property(e => e.DeductionDetailCode).HasMaxLength(10);

                entity.Property(e => e.DeductionCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ItemType).HasMaxLength(2);

                entity.HasOne(d => d.DeductionCodeNavigation)
                    .WithMany(p => p.DeductionDetail)
                    .HasForeignKey(d => d.DeductionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeductionDetail_Deduction");

                entity.HasOne(d => d.ItemTypeNavigation)
                    .WithMany(p => p.DeductionDetail)
                    .HasForeignKey(d => d.ItemType)
                    .HasConstraintName("FK_DeductionDetail_ItemType");
            });

            modelBuilder.Entity<DeductionPos>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.DeductionCode })
                    .HasName("PK_DeductionPOS");

                entity.ToTable("DeductionPOS");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeductionCode).HasMaxLength(10);

                entity.HasOne(d => d.DeductionCodeNavigation)
                    .WithMany(p => p.DeductionPos)
                    .HasForeignKey(d => d.DeductionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeductionPOS_Deduction");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.DeductionPos)
                    .HasForeignKey(d => d.Poscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeductionPOS_POS");
            });

            modelBuilder.Entity<DeductionProvince>(entity =>
            {
                entity.HasKey(e => new { e.DeductionCode, e.ProvinceCode })
                    .HasName("PK_DeductionProvince");

                entity.Property(e => e.DeductionCode).HasMaxLength(10);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.HasOne(d => d.DeductionCodeNavigation)
                    .WithMany(p => p.DeductionProvince)
                    .HasForeignKey(d => d.DeductionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeductionProvince_Deduction");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.DeductionProvince)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeductionProvince_Province");
            });

            modelBuilder.Entity<DeleteParameter>(entity =>
            {
                entity.HasKey(e => new { e.MessageTypeName, e.TableName, e.DeleteParameterName })
                    .HasName("PK_DeleteParameter");

                entity.Property(e => e.MessageTypeName).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(50);

                entity.Property(e => e.DeleteParameterName).HasMaxLength(50);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryIndex, e.ToPoscode, e.ItemCode })
                    .HasName("PK_Delivery_1");

                entity.HasIndex(e => e.DeliveryDate)
                    .HasName("IX_Delivery_DeliveryDate");

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CauseCode).HasMaxLength(2);

                entity.Property(e => e.Codamount).HasColumnName("CODAmount");

                entity.Property(e => e.Codfreight).HasColumnName("CODFreight");

                entity.Property(e => e.CollectionMoneyDate).HasColumnType("datetime");

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryCertificateDateOfIssue).HasColumnType("datetime");

                entity.Property(e => e.DeliveryCertificateName).HasMaxLength(500);

                entity.Property(e => e.DeliveryCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.DeliveryCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.DeliveryCertificatePlaceOfIssue).HasMaxLength(500);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMachine).HasMaxLength(50);

                entity.Property(e => e.DeliveryNote).HasMaxLength(2000);

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.DeliveryRouteName).HasMaxLength(500);

                entity.Property(e => e.DeliveryUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.InputingUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.ObjectTransfer).HasMaxLength(200);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PostmanCode).HasMaxLength(50);

                entity.Property(e => e.PostmanName).HasMaxLength(500);

                entity.Property(e => e.RealReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.RealReciverName).HasMaxLength(50);

                entity.Property(e => e.ReturningMoneyDate).HasColumnType("datetime");

                entity.Property(e => e.SendMailDate).HasColumnType("datetime");

                entity.Property(e => e.SendSmsdate)
                    .HasColumnName("SendSMSDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendSmssuccess).HasColumnName("SendSMSSuccess");

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.SolutionCode).HasMaxLength(2);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_Delivery_Item");

                entity.HasOne(d => d.CauseSolution)
                    .WithMany(p => p.Delivery)
                    .HasForeignKey(d => new { d.CauseCode, d.SolutionCode })
                    .HasConstraintName("FK_Delivery_CauseSolution");
            });

            modelBuilder.Entity<DeliveryOther>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryTargetCode, e.HandoverIndex, e.ShiftCode, e.CounterCode, e.Poscode, e.DeliveryPoscode, e.DeliveryRouteCode, e.PostmanCode, e.DeliveryDate })
                    .HasName("PK_DeliveryOther");

                entity.Property(e => e.DeliveryTargetCode).HasMaxLength(100);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeliveryPoscode)
                    .HasColumnName("DeliveryPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.PostmanCode).HasMaxLength(50);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryMachine).HasMaxLength(50);

                entity.Property(e => e.DeliveryRouteName).HasMaxLength(500);

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.InputingUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.PostmanName).HasMaxLength(500);
            });

            modelBuilder.Entity<DeliveryOtherTarget>(entity =>
            {
                entity.HasKey(e => e.DeliveryTargetCode)
                    .HasName("PK_DeliveryOtherTarget");

                entity.Property(e => e.DeliveryTargetCode).HasMaxLength(100);

                entity.Property(e => e.DeliveryTargetName).HasMaxLength(150);

                entity.Property(e => e.ParentDeliveryTargetCode).HasMaxLength(100);

                entity.Property(e => e.RecordNumber).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(10);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(20);
            });

            modelBuilder.Entity<DeliveryOtherTargetRule>(entity =>
            {
                entity.HasKey(e => e.DeliveryTargetCode)
                    .HasName("PK_DeliveryOtherTargetRule");

                entity.Property(e => e.DeliveryTargetCode).HasMaxLength(100);

                entity.HasOne(d => d.DeliveryTargetCodeNavigation)
                    .WithOne(p => p.DeliveryOtherTargetRule)
                    .HasForeignKey<DeliveryOtherTargetRule>(d => d.DeliveryTargetCode)
                    .HasConstraintName("FK_DeliveryOtherTargetRule_DeliveryOtherTarget");
            });

            modelBuilder.Entity<DeliveryRevenueSharing>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryRevenueSharingCode, e.RevenueSharingRuleCode, e.ServiceCode })
                    .HasName("PK_DeliveryRevenueSharing");

                entity.Property(e => e.DeliveryRevenueSharingCode).HasMaxLength(10);

                entity.Property(e => e.RevenueSharingRuleCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.RevenueSharingRule)
                    .WithMany(p => p.DeliveryRevenueSharing)
                    .HasForeignKey(d => new { d.RevenueSharingRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DeliveryRevenueSharing_RevenueSharingRule1");
            });

            modelBuilder.Entity<DeliveryRoute>(entity =>
            {
                entity.HasKey(e => new { e.DelieveryRouteCode, e.FromPoscode })
                    .HasName("PK_DeliveryRoute_1");

                entity.Property(e => e.DelieveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeliverRouteName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryRouteName).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.FromPoscodeNavigation)
                    .WithMany(p => p.DeliveryRoute)
                    .HasForeignKey(d => d.FromPoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeliveryRoute_POS");
            });

            modelBuilder.Entity<DeliveryRouteService>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryRouteCode, e.FromPoscode, e.ServiceCode })
                    .HasName("PK_DeliveryRouteService_1");

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.DeliveryRouteService)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeliveryRouteService_Service");
            });

            modelBuilder.Entity<DeliveryScoping>(entity =>
            {
                entity.HasKey(e => new { e.DeliveryRouteCode, e.FromPoscode, e.ServiceCode, e.CommuneCode })
                    .HasName("PK_DeliveryScoping");

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.DeliveryScoping)
                    .HasForeignKey(d => d.CommuneCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeliveryScoping_Commune");

                entity.HasOne(d => d.DeliveryRouteService)
                    .WithMany(p => p.DeliveryScoping)
                    .HasForeignKey(d => new { d.DeliveryRouteCode, d.FromPoscode, d.ServiceCode })
                    .HasConstraintName("FK_DeliveryScoping_DeliveryRouteService");
            });

            modelBuilder.Entity<DetailItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemIndex, e.ItemCode })
                    .HasName("PK_DetailItem");

                entity.HasIndex(e => new { e.Amount, e.ChemicalItemName, e.ChemicalName, e.ChemicalTypeCode, e.DetailItemName, e.Height, e.ItemIndex, e.Length, e.LightItem, e.OriginalCountryCode, e.Price, e.Quantity, e.TaxCode, e.Unit, e.Weight, e.Width, e.ItemCode })
                    .HasName("_dta_index_DetailItem_5_1243151474__K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChemicalItemName).HasMaxLength(500);

                entity.Property(e => e.ChemicalName).HasMaxLength(500);

                entity.Property(e => e.ChemicalTypeCode).HasMaxLength(5);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailItemName).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalCountryCode).HasMaxLength(3);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.HasOne(d => d.ChemicalTypeCodeNavigation)
                    .WithMany(p => p.DetailItem)
                    .HasForeignKey(d => d.ChemicalTypeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetailItem_ChemicalType");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.DetailItem)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_DetailItem_Item");

                entity.HasOne(d => d.OriginalCountryCodeNavigation)
                    .WithMany(p => p.DetailItem)
                    .HasForeignKey(d => d.OriginalCountryCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DetailItem_Country");
            });

            modelBuilder.Entity<DetailItemAffairCod>(entity =>
            {
                entity.HasKey(e => new { e.ItemIndex, e.ItemCode })
                    .HasName("PK_DetailItemAffairCOD");

                entity.ToTable("DetailItemAffairCOD");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChemicalItemName).HasMaxLength(500);

                entity.Property(e => e.ChemicalName).HasMaxLength(500);

                entity.Property(e => e.ChemicalTypeCode).HasMaxLength(5);

                entity.Property(e => e.DetailItemName).HasMaxLength(50);

                entity.Property(e => e.OriginalCountryCode).HasMaxLength(3);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<DetailItemChanged>(entity =>
            {
                entity.HasKey(e => new { e.ItemIndex, e.ItemCode, e.HandoverIndex, e.ChangePoscode, e.ChangeIndex })
                    .HasName("PK_DetailItemChanged_1");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ChemicalItemName).HasMaxLength(500);

                entity.Property(e => e.ChemicalName).HasMaxLength(500);

                entity.Property(e => e.ChemicalTypeCode).HasMaxLength(5);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DetailItemName).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalCountryCode).HasMaxLength(3);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.DetailItemChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DetailItemChanged_ItemChanged");
            });

            modelBuilder.Entity<DetailProvinceFreight>(entity =>
            {
                entity.HasKey(e => new { e.FromProvinceCode, e.ToProvinceCode, e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticFreightStepCode })
                    .HasName("PK_DetailProvinceFreight_1");

                entity.Property(e => e.FromProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ToProvinceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightStepCode).HasMaxLength(5);

                entity.HasOne(d => d.DomesticFreightStep)
                    .WithMany(p => p.DetailProvinceFreight)
                    .HasForeignKey(d => new { d.DomesticFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .HasConstraintName("FK_DetailProvinceFreight_DomesticFreightStep1");

                entity.HasOne(d => d.ProvinceInterconnect)
                    .WithMany(p => p.DetailProvinceFreight)
                    .HasForeignKey(d => new { d.FromProvinceCode, d.ToProvinceCode, d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DetailProvinceFreight_ProvinceInterconnect");
            });

            modelBuilder.Entity<DetailRegionFreight>(entity =>
            {
                entity.HasKey(e => new { e.FromFreightRegionCode, e.ToFreightRegionCode, e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticFreightStepCode })
                    .HasName("PK_DetailRegionFreight_1");

                entity.Property(e => e.FromFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ToFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightStepCode).HasMaxLength(5);

                entity.HasOne(d => d.DomesticFreightStep)
                    .WithMany(p => p.DetailRegionFreight)
                    .HasForeignKey(d => new { d.DomesticFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .HasConstraintName("FK_DetailRegionFreight_DomesticFreightStep1");

                entity.HasOne(d => d.RegionInterconnect)
                    .WithMany(p => p.DetailRegionFreight)
                    .HasForeignKey(d => new { d.FromFreightRegionCode, d.ToFreightRegionCode, d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DetailRegionFreight_RegionInterconnect");
            });

            modelBuilder.Entity<DetailRegionFreightDeliveryAddress>(entity =>
            {
                entity.HasKey(e => new { e.ToFreightRegionCode, e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticFreightStepCode })
                    .HasName("PK_DetailRegionFreightDeliveryAddress");

                entity.Property(e => e.ToFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightStepCode).HasMaxLength(5);

                entity.HasOne(d => d.DomesticFreightStepDeliveryAddress)
                    .WithMany(p => p.DetailRegionFreightDeliveryAddress)
                    .HasForeignKey(d => new { d.DomesticFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .HasConstraintName("FK_DetailRegionFreightDeliveryAddress_DomesticFreightStepDeliveryAddress");
            });

            modelBuilder.Entity<DetailValueAddedServiceProvinceFreight>(entity =>
            {
                entity.HasKey(e => new { e.FromProvinceCode, e.ToProvinceCode, e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticValueAddedServiceFreightStepCode, e.ValueAddedServiceCode })
                    .HasName("PK_DetailValueAddedServiceProvinceFreight_1");

                entity.Property(e => e.FromProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ToProvinceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticValueAddedServiceFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DetailValueAddedServiceProvinceFreight)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DetailValueAddedServiceProvinceFreight_DomesticFreightRule");

                entity.HasOne(d => d.DomesticValueAddedServiceFreightStep)
                    .WithMany(p => p.DetailValueAddedServiceProvinceFreight)
                    .HasForeignKey(d => new { d.DomesticValueAddedServiceFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .HasConstraintName("FK_DetailValueAddedServiceProvinceFreight_DomesticValueAddedServiceFreightStep");
            });

            modelBuilder.Entity<DetailValueAddedServiceRegionFreight>(entity =>
            {
                entity.HasKey(e => new { e.FromFreightRegionCode, e.ToFreightRegionCode, e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticValueAddedServiceFreightStepCode, e.ValueAddedServiceCode })
                    .HasName("PK_DetailValueAddedServiceRegionFreight_1");

                entity.Property(e => e.FromFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ToFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticValueAddedServiceFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DetailValueAddedServiceRegionFreight)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DetailValueAddedServiceRegionFreight_DomesticFreightRule");

                entity.HasOne(d => d.DomesticValueAddedServiceFreightStep)
                    .WithMany(p => p.DetailValueAddedServiceRegionFreight)
                    .HasForeignKey(d => new { d.DomesticValueAddedServiceFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .HasConstraintName("FK_DetailValueAddedServiceRegionFreight_DomesticValueAddedServiceFreightStep");
            });

            modelBuilder.Entity<DirectionRoute>(entity =>
            {
                entity.HasKey(e => new { e.OnMailRoutePoscode, e.ExchangePoscode, e.ServiceCode, e.DestinationCode })
                    .HasName("PK_DirectionRoute");

                entity.Property(e => e.OnMailRoutePoscode)
                    .HasColumnName("OnMailRoutePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ExchangePoscode)
                    .HasColumnName("ExchangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DestinationCode).HasMaxLength(6);
            });

            modelBuilder.Entity<Dispatch>(entity =>
            {
                entity.HasKey(e => new { e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber, e.ItemCode })
                    .HasName("PK_Dispatch");

                entity.HasIndex(e => e.DeliveryRouteCode)
                    .HasName("IX_Dispatch_DeliveryRouteCode");

                entity.HasIndex(e => e.ItemCode)
                    .HasName("_dta_index_Dispatch_11_1195151303__K8");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Dispatch_Status");

                entity.HasIndex(e => new { e.ToPoscode, e.MailTripNumber, e.Year, e.ServiceCode, e.MailTripType, e.FromPoscode })
                    .HasName("_dta_index_Dispatch_11_1195151303__K3_K7_K6_K5_K4_K2");

                entity.HasIndex(e => new { e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber, e.PostBagIndex, e.Sheet })
                    .HasName("_dta_index_Dispatch_5_1163151189__K2_K3_K4_K5_K6_K7_K1_K11D");

                entity.HasIndex(e => new { e.CounterCode, e.DeliveryRouteCode, e.IndexNumber, e.Sheet, e.ShiftCode, e.Status, e.PostBagIndex, e.FromPoscode, e.ItemCode, e.MailTripNumber, e.Year, e.ServiceCode, e.MailTripType, e.ToPoscode })
                    .HasName("_dta_index_Dispatch_5_1163151189__K2_K8_K7_K6_K5_K4_K3_1_9_10_11_12_13_14");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.PostmanCode).HasMaxLength(50);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Dispatch)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_Dispatch_Item");

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.Dispatch)
                    .HasForeignKey(d => new { d.CounterCode, d.FromPoscode })
                    .HasConstraintName("FK_Dispatch_Counter");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Dispatch)
                    .HasForeignKey(d => new { d.ShiftCode, d.FromPoscode })
                    .HasConstraintName("FK_Dispatch_Shift");

                entity.HasOne(d => d.PostBag)
                    .WithMany(p => p.Dispatch)
                    .HasForeignKey(d => new { d.PostBagIndex, d.FromPoscode, d.ToPoscode, d.MailTripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_Dispatch_PostBag");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasKey(e => e.DistrictCode)
                    .HasName("PK_District");

                entity.HasIndex(e => e.ProvinceCode)
                    .HasName("IX_District_ProvinceCode");

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_District_ProvinceCode");
            });

            modelBuilder.Entity<DistrictFreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.DistrictCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DistrictFreightRegion");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.DistrictFreightRegion)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DistrictFreightRegion_District");

                entity.HasOne(d => d.FreightRegion)
                    .WithMany(p => p.DistrictFreightRegion)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DistrictFreightRegion_FreightRegion");
            });

            modelBuilder.Entity<DistrictFreightRegionDeliveryAddress>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.DomesticFreightRuleCode, e.DistrictCode })
                    .HasName("PK_DistrictFreightRegionDeliveryAddress");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.DistrictFreightRegionDeliveryAddress)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DistrictFreightRegionDeliveryAddress_District");

                entity.HasOne(d => d.FreightRegionDeliveryAddress)
                    .WithMany(p => p.DistrictFreightRegionDeliveryAddress)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DistrictFreightRegionDeliveryAddress_FreightRegionDeliveryAddress");
            });

            modelBuilder.Entity<DnnModuleControl>(entity =>
            {
                entity.HasKey(e => e.DnnModuleControlName)
                    .HasName("PK_DnnModuleControl");

                entity.Property(e => e.DnnModuleControlName).HasMaxLength(100);

                entity.Property(e => e.DnnModuleControlFriendlyName).HasMaxLength(100);

                entity.Property(e => e.DnnModuleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<DnnModuleControlPermission>(entity =>
            {
                entity.Property(e => e.DnnModuleControlName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoleGroupName).HasMaxLength(100);

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.HasOne(d => d.DnnModuleControlNameNavigation)
                    .WithMany(p => p.DnnModuleControlPermission)
                    .HasForeignKey(d => d.DnnModuleControlName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DnnModuleControlPermission_DnnModuleControl");
            });

            modelBuilder.Entity<DomesticCollectionFreight>(entity =>
            {
                entity.HasKey(e => new { e.CollectionCode, e.DomesticFreighRuleCode, e.ServiceCode })
                    .HasName("PK_DomesticCollectionFreight");

                entity.Property(e => e.CollectionCode).HasMaxLength(10);

                entity.Property(e => e.DomesticFreighRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticCollectionFreight)
                    .HasForeignKey(d => new { d.DomesticFreighRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticCollectionFreight_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticCommodityType>(entity =>
            {
                entity.HasKey(e => new { e.CommodityTypeCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticCommodityType");

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.CommodityTypeCodeNavigation)
                    .WithMany(p => p.DomesticCommodityType)
                    .HasForeignKey(d => d.CommodityTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticCommodityType_CommodityType");

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticCommodityType)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticCommodityType_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticCompensateRule>(entity =>
            {
                entity.HasKey(e => new { e.DomesitcCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_DomesticCompensateRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_DomesticCompensateRule_ValueDate");

                entity.Property(e => e.DomesitcCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.DomesticCompensateRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticCompensateRule_Service");
            });

            modelBuilder.Entity<DomesticFarRegion>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode, e.DistrictCode })
                    .HasName("PK_DomesticFarRegion");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.HasOne(d => d.DistrictCodeNavigation)
                    .WithMany(p => p.DomesticFarRegion)
                    .HasForeignKey(d => d.DistrictCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFarRegion_District");

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticFarRegion)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFarRegion_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticFarRegionCommune>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode, e.CommuneCode })
                    .HasName("PK_DomesticFarRegionCommune");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.DomesticFarRegionCommune)
                    .HasForeignKey(d => d.CommuneCode)
                    .HasConstraintName("FK_DomesticFarRegionCommune_Commune");

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticFarRegionCommune)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticFarRegionCommune_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticFarRegionFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode, e.DomesticFarRegionFreightStepCode, e.ItemTypeCode })
                    .HasName("PK_DomesticFarRegionFreightStep");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFarRegionFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticFarRegionFreightStep)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticFarRegionFreightStep_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticFreightObject>(entity =>
            {
                entity.HasKey(e => e.DomesticFreightObjectCode)
                    .HasName("PK_DomesticFreightObject_1");

                entity.Property(e => e.DomesticFreightObjectCode).HasMaxLength(50);

                entity.Property(e => e.DomesticFreightObjectName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticFreightObject)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticFreightObject_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticFreightObjectFreight>(entity =>
            {
                entity.Property(e => e.DomesticFreightObjectFreightId).HasColumnName("DomesticFreightObjectFreightID");

                entity.Property(e => e.DomesticFreightObjectCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.DomesticFreightObjectCodeNavigation)
                    .WithMany(p => p.DomesticFreightObjectFreight)
                    .HasForeignKey(d => d.DomesticFreightObjectCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFreightObjectFreight_DomesticFreightObject");
            });

            modelBuilder.Entity<DomesticFreightProperty>(entity =>
            {
                entity.HasKey(e => e.DomesticFreightPropertyCode)
                    .HasName("PK_DomesticFreightProperty");

                entity.Property(e => e.DomesticFreightPropertyCode).HasMaxLength(50);

                entity.Property(e => e.DomesticFreightObjectCode).HasMaxLength(50);

                entity.Property(e => e.DomesticFreightPropertyName).HasMaxLength(150);

                entity.HasOne(d => d.DomesticFreightObjectCodeNavigation)
                    .WithMany(p => p.DomesticFreightProperty)
                    .HasForeignKey(d => d.DomesticFreightObjectCode)
                    .HasConstraintName("FK_DomesticFreightProperty_DomesticFreightObject");
            });

            modelBuilder.Entity<DomesticFreightPropertyValue>(entity =>
            {
                entity.Property(e => e.DomesticFreightPropertyValueId).HasColumnName("DomesticFreightPropertyValueID");

                entity.Property(e => e.DomesticFreightObjectFreightId).HasColumnName("DomesticFreightObjectFreightID");

                entity.Property(e => e.DomesticFreightPropertyCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.DomesticFreightObjectFreight)
                    .WithMany(p => p.DomesticFreightPropertyValue)
                    .HasForeignKey(d => d.DomesticFreightObjectFreightId)
                    .HasConstraintName("FK_DomesticFreightPropertyValue_DomesticFreightObjectFreight");

                entity.HasOne(d => d.DomesticFreightPropertyCodeNavigation)
                    .WithMany(p => p.DomesticFreightPropertyValue)
                    .HasForeignKey(d => d.DomesticFreightPropertyCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFreightPropertyValue_DomesticFreightProperty");
            });

            modelBuilder.Entity<DomesticFreightRule>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode })
                    .HasName("PK_DomesticFreightRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_DomesticFreightRule_ValueDate");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.HasVat).HasColumnName("HasVAT");

                entity.Property(e => e.ProvinceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNo).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.Vatpercent).HasColumnName("VATPercent");
            });

            modelBuilder.Entity<DomesticFreightRuleItemTypeUsing>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.DomesticFreightRuleCode, e.ItemTypeCode })
                    .HasName("PK_DomesticFreightRuleItemTypeUsing");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.HasVat).HasColumnName("HasVAT");

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.DomesticFreightRuleItemTypeUsing)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFreightRuleItemTypeUsing_ItemType");

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticFreightRuleItemTypeUsing)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFreightRuleItemTypeUsing_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticFreightRuleLastUpdate>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode })
                    .HasName("PK_DomesticFreightRuleLastUpdate");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DomesticFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightStepCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticFreightStep");

                entity.Property(e => e.DomesticFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.DomesticFreightStep)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticFreightStep_ItemType");
            });

            modelBuilder.Entity<DomesticFreightStepDeliveryAddress>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightStepCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticFreightStepDeliveryAddress");

                entity.Property(e => e.DomesticFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);
            });

            modelBuilder.Entity<DomesticServiceSurchange>(entity =>
            {
                entity.HasKey(e => new { e.DomesticServiceSurchangeCode, e.ServiceCode, e.ValueDate })
                    .HasName("PK_DomesticServiceSurchange");

                entity.Property(e => e.DomesticServiceSurchangeCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.DomesticServiceSurchange)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticServiceSurchange_Service");
            });

            modelBuilder.Entity<DomesticSurchangeValueAddedServicePercent>(entity =>
            {
                entity.HasKey(e => new { e.DomesticFreightRuleCode, e.ServiceCode, e.ValueAddedServiceCode, e.ValueDate })
                    .HasName("PK_DomesticSurchangeValueAddedServicePercent_1");

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticSurchangeValueAddedServicePercent)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticSurchangeValueAddedServicePercent_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticSurchangeValueAddedServicePercent)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticSurchangeValueAddedServicePercent_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPerItem>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPerItemCode, e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPerItem");

                entity.Property(e => e.DomesticValueAddedServiceFreightPerItemCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerItem)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerItem_DomesticFreightRule");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPerMoney>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPerMoneyCode, e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPerMoney");

                entity.Property(e => e.DomesticValueAddedServiceFreightPerMoneyCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerMoney)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerMoney_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerMoney)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerMoney_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPerStockDay>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPerStockDayCode, e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPerStockDay");

                entity.Property(e => e.DomesticValueAddedServiceFreightPerStockDayCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerStockDay)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerStockDay_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerStockDay)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerStockDay_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPerTotalItem>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPerTotalItemCode, e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPerTotalItem");

                entity.Property(e => e.DomesticValueAddedServiceFreightPerTotalItemCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerTotalItem)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerTotalItem_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerTotalItem)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerTotalItem_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPerTotalItemInBatch>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode, e.DomesticValueAddedServiceFreightPerTotalItemInBatchCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPerTotalItemInBatch_1");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.DomesticValueAddedServiceFreightPerTotalItemInBatchCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerTotalItemInBatch)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerTotalItemInBatch_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPerTotalItemInBatch)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPerTotalItemInBatch_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightPercentMainFreight>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPercentMainFreightCode, e.ServiceCode, e.ValueAddedServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightPercentMainFreight");

                entity.Property(e => e.DomesticValueAddedServiceFreightPercentMainFreightCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPercentMainFreight)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPercentMainFreight_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightPercentMainFreight)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightPercentMainFreight_VASUsing");
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightStepCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_DomesticValueAddedServiceFreightStep");

                entity.Property(e => e.DomesticValueAddedServiceFreightStepCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);
            });

            modelBuilder.Entity<DomesticValueAddedServiceFreightTotalWeight>(entity =>
            {
                entity.HasKey(e => new { e.DomesticValueAddedServiceFreightPerTotalWeightCode, e.ValueAddedServiceCode, e.ServiceCode, e.DomesticFreightRuleCode, e.DomesticValueAddedServiceFreightStepCode })
                    .HasName("PK_DomesticValueAddedServiceFreightTotalWeight");

                entity.Property(e => e.DomesticValueAddedServiceFreightPerTotalWeightCode).HasMaxLength(10);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.DomesticValueAddedServiceFreightStepCode).HasMaxLength(5);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.DomesticValueAddedServiceFreightTotalWeight)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightTotalWeight_DomesticFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.DomesticValueAddedServiceFreightTotalWeight)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightTotalWeight_VASUsing");

                entity.HasOne(d => d.DomesticValueAddedServiceFreightStep)
                    .WithMany(p => p.DomesticValueAddedServiceFreightTotalWeight)
                    .HasForeignKey(d => new { d.DomesticValueAddedServiceFreightStepCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DomesticValueAddedServiceFreightTotalWeight_DomesticValueAddedFreightStep");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.HasKey(e => new { e.DriverCode, e.Poscode })
                    .HasName("PK_Driver");

                entity.Property(e => e.DriverCode).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DriverName).HasMaxLength(50);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Driver)
                    .HasForeignKey(d => d.Poscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Driver_POS");
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.HasKey(e => e.EmailId)
                    .HasName("PK_EmailAccount");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Enable).HasDefaultValueSql("0");

                entity.Property(e => e.EnableSsl)
                    .HasColumnName("EnableSSL")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.From).HasMaxLength(100);

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.To).HasMaxLength(200);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.HasKey(e => e.ExchangeCode)
                    .HasName("PK_Exchange");

                entity.Property(e => e.ExchangeCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ExchangeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ExchangeRate>(entity =>
            {
                entity.HasKey(e => e.ExchangeRateCode)
                    .HasName("PK_ExchangeRate");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_ExchangeRate_ValueDate");

                entity.Property(e => e.ExchangeRateCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeRateCodeBased).HasMaxLength(3);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ExchangeCodeNavigation)
                    .WithMany(p => p.ExchangeRate)
                    .HasForeignKey(d => d.ExchangeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ExchangeRate_Exchange");
            });

            modelBuilder.Entity<ExchangeRelationship>(entity =>
            {
                entity.HasKey(e => new { e.OnMailRoutePoscode, e.ExchangePoscode, e.ServiceCode })
                    .HasName("PK_ExchangeRelationship");

                entity.HasIndex(e => new { e.ExchangePoscode, e.OnMailRoutePoscode })
                    .HasName("_dta_index_ExchangeRelationship_11_1858105660__K4_K2");

                entity.Property(e => e.OnMailRoutePoscode)
                    .HasColumnName("OnMailRoutePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ExchangePoscode)
                    .HasColumnName("ExchangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.MailRouteScheduleCode).HasMaxLength(5);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ExchangeRelationship)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ExchangeRelationship_Service");
            });

            modelBuilder.Entity<ExchangeServiceHistory>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.Apiname })
                    .HasName("PK_ExchangeServiceHistory");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Apiname)
                    .HasColumnName("APIName")
                    .HasMaxLength(400);

                entity.Property(e => e.LastCall).HasColumnType("datetime");
            });

            modelBuilder.Entity<FreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_FreightRegion_1");

                entity.HasIndex(e => e.ServiceCode)
                    .HasName("IX_FreightRegion_ServiceCode");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FreightRegionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.FreightRegion)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FreightRegion_DomesticFreightRule");
            });

            modelBuilder.Entity<FreightRegionDeliveryAddress>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_FreightRegionDeliveryAddress");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FreightRegionName).HasMaxLength(100);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.FreightRegionDeliveryAddress)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FreightRegionDeliveryAddress_DomesticFreightRule");
            });

            modelBuilder.Entity<GetDependOn>(entity =>
            {
                entity.HasKey(e => new { e.MessageTypeName, e.TableName, e.ColumnName, e.GetDependOnTableName, e.GetDependOnColumnName })
                    .HasName("PK_GetDependOn_1");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.GetDependOnTableName).HasMaxLength(50);

                entity.Property(e => e.GetDependOnColumnName).HasMaxLength(50);

                entity.HasOne(d => d.MessageTypeTable)
                    .WithMany(p => p.GetDependOn)
                    .HasForeignKey(d => new { d.MessageTypeName, d.TableName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GetDependOn_MessageTypeTable");
            });

            modelBuilder.Entity<GetParameter>(entity =>
            {
                entity.HasKey(e => new { e.MessageTypeName, e.TableName, e.GetParameterName })
                    .HasName("PK_GetParameter_1");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.GetParameterName).HasMaxLength(50);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MessageTypeTable)
                    .WithMany(p => p.GetParameter)
                    .HasForeignKey(d => new { d.MessageTypeName, d.TableName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_GetParameter_MessageTypeTable");
            });

/*            modelBuilder.Entity<GetType>(entity =>
            {
                entity.Property(e => e.GetTypeId).ValueGeneratedNever();

                entity.Property(e => e.GetTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });*/

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.GroupCode)
                    .HasName("PK_Group");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GroupMenu>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.MenuCode })
                    .HasName("PK_GroupMenu");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.MenuCode).HasMaxLength(10);

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GroupMenu)
                    .HasForeignKey(d => d.GroupCode)
                    .HasConstraintName("FK_GroupMenu_Group");

                entity.HasOne(d => d.MenuCodeNavigation)
                    .WithMany(p => p.GroupMenu)
                    .HasForeignKey(d => d.MenuCode)
                    .HasConstraintName("FK_GroupMenu_Menu");
            });

            modelBuilder.Entity<GroupProperty>(entity =>
            {
                entity.HasKey(e => e.GroupPropertyCode)
                    .HasName("PK_GroupProperty");

                entity.Property(e => e.GroupPropertyCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupPropertyName).HasMaxLength(500);
            });

            modelBuilder.Entity<GroupRole>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.RoleCode })
                    .HasName("PK_GroupRole");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.RoleCode).HasMaxLength(50);

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.GroupRole)
                    .HasForeignKey(d => d.GroupCode)
                    .HasConstraintName("FK_GroupRole_Group");

                entity.HasOne(d => d.RoleCodeNavigation)
                    .WithMany(p => p.GroupRole)
                    .HasForeignKey(d => d.RoleCode)
                    .HasConstraintName("FK_GroupRole_Role");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasKey(e => e.HolidayCode)
                    .HasName("PK__Holidays__2B803210");

                entity.Property(e => e.HolidayCode).ValueGeneratedNever();

                entity.Property(e => e.HolidayDate).HasColumnType("datetime");

                entity.Property(e => e.HolidayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Reason).HasMaxLength(200);
            });

            modelBuilder.Entity<InlandFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalMailFreightRuleCode, e.ServiceCode, e.CountryCode })
                    .HasName("PK_InlandFreight");

                entity.Property(e => e.InternationalMailFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.InlandFreight)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_InlandFreight_Country");

                entity.HasOne(d => d.InternationalMailFreightRule)
                    .WithMany(p => p.InlandFreight)
                    .HasForeignKey(d => new { d.InternationalMailFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InlandFreight_InternationalMailFreightRule");
            });

            modelBuilder.Entity<InternationalAirSurchargeFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalAirSurchargeFreightCode, e.InternationalFreightRuleCode, e.ServiceCode })
                    .HasName("PK_InternationalAirSurchargeFreight");

                entity.Property(e => e.InternationalAirSurchargeFreightCode).HasMaxLength(10);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ContinentCode).HasMaxLength(2);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.ContinentCodeNavigation)
                    .WithMany(p => p.InternationalAirSurchargeFreight)
                    .HasForeignKey(d => d.ContinentCode)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_InternationalAirSurchargeFreight_Continent");

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.InternationalAirSurchargeFreight)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_InternationalAirSurchargeFreight_ItemType");

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalAirSurchargeFreight)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalAirSurchargeFreight_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalCommodityType>(entity =>
            {
                entity.HasKey(e => new { e.CommodityTypeCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalCommodityType");

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.CommodityTypeCodeNavigation)
                    .WithMany(p => p.InternationalCommodityType)
                    .HasForeignKey(d => d.CommodityTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCommodityType_CommodityType");

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalCommodityType)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalCommodityType_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalCompensateRule>(entity =>
            {
                entity.HasKey(e => new { e.InternationalCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_InternationalCompensateRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_InternationalCompensateRule_ValueDate");

                entity.Property(e => e.InternationalCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ClaimTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CompensateCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompensatePoscode)
                    .IsRequired()
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeciderName).HasMaxLength(50);

                entity.Property(e => e.ExchangeCode).HasMaxLength(3);

                entity.Property(e => e.InputDecideDate).HasColumnType("datetime");

                entity.Property(e => e.InputDeciderName).HasMaxLength(50);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ClaimTypeCodeNavigation)
                    .WithMany(p => p.InternationalCompensateRule)
                    .HasForeignKey(d => d.ClaimTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCompensateRule_ClaimType");

                entity.HasOne(d => d.CompensateCategoryCodeNavigation)
                    .WithMany(p => p.InternationalCompensateRule)
                    .HasForeignKey(d => d.CompensateCategoryCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCompensateRule_CompensateCategory");

                entity.HasOne(d => d.CompensatePoscodeNavigation)
                    .WithMany(p => p.InternationalCompensateRule)
                    .HasForeignKey(d => d.CompensatePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCompensateRule_POS");

                entity.HasOne(d => d.ExchangeCodeNavigation)
                    .WithMany(p => p.InternationalCompensateRule)
                    .HasForeignKey(d => d.ExchangeCode)
                    .HasConstraintName("FK_InternationalCompensateRule_Exchange");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalCompensateRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCompensateRule_Service");
            });

            modelBuilder.Entity<InternationalCountryFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalCountryFreightCode, e.InternationalFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode, e.CountryCode })
                    .HasName("PK_InternationalCountryFreight");

                entity.Property(e => e.InternationalCountryFreightCode).HasMaxLength(50);

                entity.Property(e => e.InternationalFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalCountryFreight)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalCountryFreight_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalCountryRegion>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.InternationalFreightRegionCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalCountryRegion");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.InternationalFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.InternationalCountryRegion)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_InternationalCountryRegion_Country");

                entity.HasOne(d => d.InternationalFreightRegion)
                    .WithMany(p => p.InternationalCountryRegion)
                    .HasForeignKey(d => new { d.InternationalFreightRegionCode, d.ServiceCode, d.InternationalFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalCountryRegion_InternationalFreightRegion");
            });

            modelBuilder.Entity<InternationalFarRegionFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightRuleCode, e.ServiceCode, e.InternationalFarRegionFreightStepCode, e.ItemTypeCode })
                    .HasName("PK_InternationalFarRegionFreightStep");

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFarRegionFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalFarRegionFreightStep)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalFarRegionFreightStep_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightCode, e.InternationalFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode, e.InternationalFreightRegionCode })
                    .HasName("PK_InternationalFreight");

                entity.Property(e => e.InternationalFreightCode).HasMaxLength(50);

                entity.Property(e => e.InternationalFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.InternationalFreightRegionCode).HasMaxLength(2);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalFreight)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalFreight_InternationalFreightRule");

                entity.HasOne(d => d.InternationalFreightRegion)
                    .WithMany(p => p.InternationalFreight)
                    .HasForeignKey(d => new { d.InternationalFreightRegionCode, d.ServiceCode, d.InternationalFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreight_InternationalFreightRegion");

                entity.HasOne(d => d.InternationalFreightStep)
                    .WithMany(p => p.InternationalFreight)
                    .HasForeignKey(d => new { d.InternationalFreightStepCode, d.ServiceCode, d.InternationalFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreight_InternationalFreightStep");
            });

            modelBuilder.Entity<InternationalFreightObject>(entity =>
            {
                entity.HasKey(e => e.InternationalFreightObjectCode)
                    .HasName("PK_InternationalFreightObject");

                entity.Property(e => e.InternationalFreightObjectCode).HasMaxLength(50);

                entity.Property(e => e.InternationalFreightObjectName).HasMaxLength(150);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalFreightObject)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalFreightObject_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalFreightObjectFreight>(entity =>
            {
                entity.HasKey(e => e.InterntationalFreightObjectFreightId)
                    .HasName("PK_InternationalFreightObjectFreight");

                entity.Property(e => e.InterntationalFreightObjectFreightId).HasColumnName("InterntationalFreightObjectFreightID");

                entity.Property(e => e.InternationalFreightObjectCode).HasMaxLength(50);

                entity.HasOne(d => d.InternationalFreightObjectCodeNavigation)
                    .WithMany(p => p.InternationalFreightObjectFreight)
                    .HasForeignKey(d => d.InternationalFreightObjectCode)
                    .HasConstraintName("FK_InternationalFreightObjectFreight_InternationalFreightObject");
            });

            modelBuilder.Entity<InternationalFreightProperty>(entity =>
            {
                entity.HasKey(e => e.InternationalFreightPropertyCode)
                    .HasName("PK_InternationalFreightProperty");

                entity.Property(e => e.InternationalFreightPropertyCode).HasMaxLength(50);

                entity.Property(e => e.InternationalFreightObjectCode).HasMaxLength(50);

                entity.Property(e => e.InternationalFreightPropertyName).HasMaxLength(150);

                entity.HasOne(d => d.InternationalFreightObjectCodeNavigation)
                    .WithMany(p => p.InternationalFreightProperty)
                    .HasForeignKey(d => d.InternationalFreightObjectCode)
                    .HasConstraintName("FK_InternationalFreightProperty_InternationalFreightObject");
            });

            modelBuilder.Entity<InternationalFreightPropertyValue>(entity =>
            {
                entity.Property(e => e.InternationalFreightPropertyValueId).HasColumnName("InternationalFreightPropertyValueID");

                entity.Property(e => e.InternationalFreightPropertyCode).HasMaxLength(50);

                entity.Property(e => e.InterntationalFreightObjectFreightId).HasColumnName("InterntationalFreightObjectFreightID");

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.HasOne(d => d.InternationalFreightPropertyCodeNavigation)
                    .WithMany(p => p.InternationalFreightPropertyValue)
                    .HasForeignKey(d => d.InternationalFreightPropertyCode)
                    .HasConstraintName("FK_InternationalFreightPropertyValue_InternationalFreightProperty");

                entity.HasOne(d => d.InterntationalFreightObjectFreight)
                    .WithMany(p => p.InternationalFreightPropertyValue)
                    .HasForeignKey(d => d.InterntationalFreightObjectFreightId)
                    .HasConstraintName("FK_InternationalFreightPropertyValue_InternationalFreightObjectFreight");
            });

            modelBuilder.Entity<InternationalFreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightRegionCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalFreightRegion");

                entity.Property(e => e.InternationalFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.InternationalFreightRegionName).HasMaxLength(500);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalFreightRegion)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightRegion_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalFreightRule>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightRuleCode, e.ServiceCode })
                    .HasName("PK_InternationalFreightRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_InternationalFreightRule_ValueDate");

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ExchangeType).HasMaxLength(3);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.HasVat).HasColumnName("HasVAT");

                entity.Property(e => e.ProvinceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNo).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.Vatpercent).HasColumnName("VATPercent");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalFreightRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightRule_Service");
            });

            modelBuilder.Entity<InternationalFreightRuleItemTypeUsing>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.InternationalFreightRuleCode, e.ItemTypeCode })
                    .HasName("PK_InternationalFreightRuleItemTypeUsing");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.InternationalFreightRuleItemTypeUsing)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightRuleItemTypeUsing_ItemType");

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalFreightRuleItemTypeUsing)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightRuleItemTypeUsing_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalFreightSharing>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightSharingCode, e.ServiceCode, e.CountryCode, e.TransportTypeCode })
                    .HasName("PK_InternationalFreightSharing");

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.InternationalFreightSharing)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_InternationalFreightSharing_Country");

                entity.HasOne(d => d.ExchangeRateCodeNavigation)
                    .WithMany(p => p.InternationalFreightSharing)
                    .HasForeignKey(d => d.ExchangeRateCode)
                    .HasConstraintName("FK_InternationalFreightSharing_ExchangeRate");

                entity.HasOne(d => d.TransportTypeCodeNavigation)
                    .WithMany(p => p.InternationalFreightSharing)
                    .HasForeignKey(d => d.TransportTypeCode)
                    .HasConstraintName("FK_InternationalFreightSharing_TransportType");

                entity.HasOne(d => d.InternationalFreightSharingRule)
                    .WithMany(p => p.InternationalFreightSharing)
                    .HasForeignKey(d => new { d.ServiceCode, d.InternationalFreightSharingCode })
                    .HasConstraintName("FK_InternationalFreightSharing_InternationalFreightSharingRule");
            });

            modelBuilder.Entity<InternationalFreightSharingRule>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.InternationalFreightSharingCode })
                    .HasName("PK_InternationalFreightSharingRule");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalFreightSharingRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightSharingRule_Service");
            });

            modelBuilder.Entity<InternationalFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalFreightStep_1");

                entity.Property(e => e.InternationalFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.InternationalFreightStep)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalFreightStep_ItemType");
            });

            modelBuilder.Entity<InternationalMailFreightRule>(entity =>
            {
                entity.HasKey(e => new { e.InternationalMailFreightRuleCode, e.ServiceCode })
                    .HasName("PK_InternationalMailFreightRule");

                entity.Property(e => e.InternationalMailFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Lcaorate).HasColumnName("LCAORate");

                entity.Property(e => e.Mrate).HasColumnName("MRate");

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalMailFreightRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_InternationalMailFreightRule_Service");
            });

            modelBuilder.Entity<InternationalReturnFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightSharingCode, e.ServiceCode, e.CountryCode, e.TransportTypeCode, e.TransitCountryCode })
                    .HasName("PK_InternationalReturnFreight");

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.TransitCountryCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.InternationalReturnFreightRule)
                    .WithMany(p => p.InternationalReturnFreight)
                    .HasForeignKey(d => new { d.ServiceCode, d.InternationalFreightSharingCode })
                    .HasConstraintName("FK_InternationalReturnFreight_InternationalReturnFreightRule");
            });

            modelBuilder.Entity<InternationalReturnFreightRule>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.InternationalFreightSharingCode })
                    .HasName("PK_InternationalReturnFreightRule");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalReturnFreightRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_InternationalReturnFreightRule_Service");
            });

            modelBuilder.Entity<InternationalServiceSurchange>(entity =>
            {
                entity.HasKey(e => new { e.InternationalServiceSurchangeCode, e.ServiceCode, e.ValueDate })
                    .HasName("PK_InternationalServiceSurchange");

                entity.Property(e => e.InternationalServiceSurchangeCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalServiceSurchange)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalServiceSurchange_Service");
            });

            modelBuilder.Entity<InternationalSurchangeValueAddedServicePercent>(entity =>
            {
                entity.HasKey(e => new { e.InternationalFreightRuleCode, e.ServiceCode, e.ValueAddedServiceCode, e.ValueDate })
                    .HasName("PK_InternationalSurchangeValueAddedServicePercent");

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<InternationalTransitFreight>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.InternationalFreightSharingCode, e.CountryCode, e.TransportTypeCode, e.TransitCountryCode })
                    .HasName("PK_InternationalTransitFreight");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.TransitCountryCode).HasMaxLength(3);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.InternationalTransitFreightRule)
                    .WithMany(p => p.InternationalTransitFreight)
                    .HasForeignKey(d => new { d.ServiceCode, d.InternationalFreightSharingCode })
                    .HasConstraintName("FK_InternationalTransitFreight_InternationalTransitFreightRule");
            });

            modelBuilder.Entity<InternationalTransitFreightRule>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.InternationalFreightSharingCode })
                    .HasName("PK_InternationalTransitFreightRule");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightSharingCode).HasMaxLength(10);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.InternationalTransitFreightRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_InternationalTransitFreightRule_Service");
            });

            modelBuilder.Entity<InternationalValueAddedServiceCountryFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceCountryFreightCode, e.InternationalValueAddedServiceFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode, e.CountryCode, e.ValueAddedServiceCode })
                    .HasName("PK_InternationalValueAddedServiceCountryFreight");

                entity.Property(e => e.InternationalValueAddedServiceCountryFreightCode).HasMaxLength(10);

                entity.Property(e => e.InternationalValueAddedServiceFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.InternationalValueAddedServiceCountryFreight)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceCountryFreight_Country");

                entity.HasOne(d => d.ValueAddedServiceCodeNavigation)
                    .WithMany(p => p.InternationalValueAddedServiceCountryFreight)
                    .HasForeignKey(d => d.ValueAddedServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceCountryFreight_ValueAddedService");

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalValueAddedServiceCountryFreight)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceCountryFreight_InternationalFreightRule");

                entity.HasOne(d => d.InternationalValueAddedServiceFreightStep)
                    .WithMany(p => p.InternationalValueAddedServiceCountryFreight)
                    .HasForeignKey(d => new { d.InternationalValueAddedServiceFreightStepCode, d.ServiceCode, d.InternationalFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceCountryFreight_InternationalValueAddedServiceFreightStep");
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightCode, e.InternationalValueAddedServiceFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode, e.InternationalFreightRegionCode, e.ValueAddedServiceCode })
                    .HasName("PK_InternationalValueAddedServiceFreight");

                entity.Property(e => e.InternationalValueAddedServiceFreightCode).HasMaxLength(10);

                entity.Property(e => e.InternationalValueAddedServiceFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.InternationalFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightPerItem>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightPerItemCode, e.ServiceCode, e.ValueAddedServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalValueAddedServiceFreightPerItem");

                entity.Property(e => e.InternationalValueAddedServiceFreightPerItemCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerItem)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerItem_InternationalFreightRule");
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightPerTotalItem>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightPerTotalItemCode, e.ValueAddedServiceCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalValueAddedServiceFreightPerTotalItem");

                entity.Property(e => e.InternationalValueAddedServiceFreightPerTotalItemCode).HasMaxLength(10);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerTotalItem)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerTotalItem_InternationalFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerTotalItem)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerTotalItem_VASUsing");
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightPerTotalItemInBatch>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.InternationalFreightRuleCode, e.InternationalValueAddedServiceFreightPerTotalItemInBatchCode })
                    .HasName("PK_InternationalValueAddedServiceFreightPerTotalItemInBatch");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.InternationalValueAddedServiceFreightPerTotalItemInBatchCode).HasMaxLength(10);
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightPerTotalWeight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightPerTotalWeightCode, e.ValueAddedServiceCode, e.ServiceCode, e.InternationalFreightRuleCode, e.InternationalValueAddedServiceFreightStepCode })
                    .HasName("PK_InternationalValueAddedServiceFreightPerTotalWeight");

                entity.Property(e => e.InternationalValueAddedServiceFreightPerTotalWeightCode).HasMaxLength(10);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.InternationalValueAddedServiceFreightStepCode).HasMaxLength(10);

                entity.HasOne(d => d.InternationalFreightRule)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerTotalWeight)
                    .HasForeignKey(d => new { d.InternationalFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerTotalWeight_InternationalFreightRule");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerTotalWeight)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerTotalWeight_VASUsing");

                entity.HasOne(d => d.InternationalValueAddedServiceFreightStep)
                    .WithMany(p => p.InternationalValueAddedServiceFreightPerTotalWeight)
                    .HasForeignKey(d => new { d.InternationalValueAddedServiceFreightStepCode, d.ServiceCode, d.InternationalFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_InternationalValueAddedServiceFreightPerTotalWeight_InternationalValueAddedServiceFreightStep");
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightPercentMainFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightPercentMainFreightCode, e.ServiceCode, e.ValueAddedServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalValueAddedServiceFreightPercentMainFreight");

                entity.Property(e => e.InternationalValueAddedServiceFreightPercentMainFreightCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);
            });

            modelBuilder.Entity<InternationalValueAddedServiceFreightStep>(entity =>
            {
                entity.HasKey(e => new { e.InternationalValueAddedServiceFreightStepCode, e.ServiceCode, e.InternationalFreightRuleCode })
                    .HasName("PK_InternationalValueAddedServiceFreightStep");

                entity.Property(e => e.InternationalValueAddedServiceFreightStepCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.InternationalFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);
            });

            modelBuilder.Entity<Invitation>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.InvitationDate })
                    .HasName("PK_Invitation");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.InvitationDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.Invitation)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_Invitation_Item");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.ItemCode)
                    .HasName("PK_Item");

                entity.HasIndex(e => e.AcceptancePoscode)
                    .HasName("IX_Item_AcceptancePOSCode");

                entity.HasIndex(e => e.BatchCode)
                    .HasName("IX_Item_BatchCode");

                entity.HasIndex(e => e.CountryCode)
                    .HasName("IX_Item_CountryCode");

                entity.HasIndex(e => e.ItemTypeCode)
                    .HasName("IX_Item_ItemTypeCode");

                entity.HasIndex(e => e.Poscode)
                    .HasName("IX_Item_POSCode");

                entity.HasIndex(e => e.ProvinceCode)
                    .HasName("IX_Item_ProvinceCode");

                entity.HasIndex(e => e.SendingTime)
                    .HasName("IX_Item_SendingTime");

                entity.HasIndex(e => e.ServiceCode)
                    .HasName("IX_Item_ServiceCode");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Item_Status");

                entity.HasIndex(e => new { e.LightItem, e.Weight, e.ItemCode })
                    .HasName("_dta_index_Item_5_123147484__K1_20_26");

                entity.HasIndex(e => new { e.TotalFreightDiscount, e.TotalFreightDiscountVat, e.Weight, e.IsDebt, e.IsDomestic, e.IsPostFree, e.ItemCode, e.ItemTypeCode, e.Poscode, e.AcceptancePoscode, e.BatchCode, e.SendingTime, e.ServiceCode })
                    .HasName("Item_Report_Offline01");

                entity.HasIndex(e => new { e.AcceptancePoscode, e.AcceptedType, e.ItemCode, e.MainFreight, e.SenderAddress, e.ServiceCode, e.SubFreight, e.Total, e.TotalFreight, e.TotalFreightDiscount, e.TotalFreightDiscountVat, e.TotalFreightVat, e.Vatfreight, e.Weight, e.SenderFullname, e.SendingTime })
                    .HasName("_dta_index_Item_5_123147484__K3_K18_1_2_4_20_22_40_41_42_60_105_106_113_114_115");

                entity.HasIndex(e => new { e.Bc16index, e.CertificateNumber, e.CheckContentOnDeliveryCode, e.CheckSum, e.Codaddress, e.Codpayment, e.CountryCode, e.CustomerAccountNo, e.CustomerCode, e.DataCode, e.DecisionDate, e.DecisionNo, e.DeliveryCounter, e.DestinationPoscode, e.Discount, e.DiscountAmount, e.DiscountPercentage, e.EmployeeCode, e.ExchangeRateCode, e.ExecuteOrder, e.FarRegion, e.FarRegionFreight, e.FeedbackAmount, e.FeedbackPercentage, e.FuelSurchargeFreight, e.Height, e.IncomingIndex, e.InvoiceAttached, e.InvoiceExport, e.InvoiceNumber, e.IsAffair, e.IsAirmail, e.IsAirmailForward, e.IsAirmailReturn, e.IsCollection, e.IsCompensate, e.IsDebt, e.IsDiscount, e.IsDomestic, e.IsFeedback, e.IsForward, e.IsOpened, e.IsPostFree, e.IsReturn, e.IsStatePrice, e.ItemCode, e.ItemNumber, e.ItemTypeCode, e.Length, e.LetterMoneyOrderFreight, e.LicenseNumber, e.LightItem, e.MachineName, e.MainFreight, e.Note, e.OrderCode, e.OtherAttached, e.OtherAttachedInfor, e.OtherFreight, e.PaymentFreight, e.PaymentFreightDiscount, e.PaymentFreightDiscountVat, e.PaymentFreightVat, e.Poscode, e.PrintedNumber, e.ProvinceCode, e.ReceiverAddress, e.ReceiverAddressCode, e.ReceiverCommuneCode, e.ReceiverContact, e.ReceiverCustomReference, e.ReceiverDistrictCode, e.ReceiverEmail, e.ReceiverFax, e.ReceiverFullname, e.ReceiverIdentification, e.ReceiverIssueCountry, e.ReceiverIssueDate, e.ReceiverJob, e.ReceiverMobile, e.ReceiverTaxCode, e.ReceiverTel, e.RemainingFreight, e.RemainingFreightDiscount, e.RemainingFreightDiscountVat, e.RemainingFreightVat, e.ReturnBeforeDate, e.ReturnDayNumber, e.SectionCode, e.SenderAddress, e.SenderAddressCode, e.SenderCustomReference, e.SenderDistrictCode, e.SenderEmail, e.SenderFax, e.SenderFullname, e.SenderIdentification, e.SenderIssueCountry, e.SenderIssueDate, e.SenderJob, e.SenderMobile, e.SenderTaxCode, e.SenderTel, e.SendingContent, e.SendingTime, e.ServiceCode, e.StatePriceFreight, e.StatePriceValue, e.Status, e.SubFreight, e.Total, e.TotalFreight, e.TotalFreightDiscount, e.TotalFreightDiscountVat, e.TotalFreightVat, e.TransferDate, e.TransferMachine, e.TransferPoscode, e.TransferStatus, e.TransferTimes, e.TransferUser, e.UndeliverableGuide, e.UndeliverableReason, e.ValueAddedServiceFreightTotalFreight, e.Vatfreight, e.Vatpercentage, e.Weight, e.WeightConvert, e.Width, e.Abatement, e.AcceptancePoscode, e.AcceptedIndex, e.AcceptedType, e.AdviceOfReceiptCode, e.AirSurchargeFreight, e.BatchCode })
                    .HasName("_dta_index_Item_5_123147484__K6_1_2_3_4_5_7_8_9_10_11_12_13_14_15_16_17_18_19_20_21_22_23_24_25_26_27_28_29_30_31_32_33_34_35_");

                entity.HasIndex(e => new { e.ServiceCode, e.StatePriceFreight, e.StatePriceValue, e.Status, e.SubFreight, e.Total, e.TotalFreight, e.TotalFreightDiscount, e.TotalFreightDiscountVat, e.TotalFreightVat, e.TransferDate, e.TransferMachine, e.TransferPoscode, e.TransferStatus, e.TransferTimes, e.TransferUser, e.UndeliverableGuide, e.UndeliverableReason, e.ValueAddedServiceFreightTotalFreight, e.Vatfreight, e.Vatpercentage, e.Weight, e.WeightConvert, e.Width, e.Abatement, e.AcceptancePoscode, e.AcceptedIndex, e.AcceptedType, e.AdviceOfReceiptCode, e.AirSurchargeFreight, e.BatchCode, e.Bc16index, e.CertificateNumber, e.CheckContentOnDeliveryCode, e.CheckSum, e.Codaddress, e.Codpayment, e.CountryCode, e.CustomerAccountNo, e.DataCode, e.DecisionDate, e.DecisionNo, e.DeliveryCounter, e.DestinationPoscode, e.Discount, e.DiscountAmount, e.DiscountPercentage, e.EmployeeCode, e.ExchangeRateCode, e.ExecuteOrder, e.FarRegion, e.FarRegionFreight, e.FeedbackAmount, e.FeedbackPercentage, e.FuelSurchargeFreight, e.Height, e.IncomingIndex, e.InvoiceAttached, e.InvoiceExport, e.InvoiceNumber, e.IsAffair, e.IsAirmail, e.IsAirmailForward, e.IsAirmailReturn, e.IsCollection, e.IsCompensate, e.IsDebt, e.IsDiscount, e.IsDomestic, e.IsFeedback, e.IsForward, e.IsOpened, e.IsPostFree, e.IsReturn, e.IsStatePrice, e.ItemCode, e.ItemNumber, e.ItemTypeCode, e.Length, e.LetterMoneyOrderFreight, e.LicenseNumber, e.LightItem, e.MachineName, e.MainFreight, e.Note, e.OrderCode, e.OtherAttached, e.OtherAttachedInfor, e.OtherFreight, e.PaymentFreight, e.PaymentFreightDiscount, e.PaymentFreightDiscountVat, e.PaymentFreightVat, e.Poscode, e.PrintedNumber, e.ProvinceCode, e.ReceiverAddress, e.ReceiverAddressCode, e.ReceiverCommuneCode, e.ReceiverContact, e.ReceiverCustomReference, e.ReceiverDistrictCode, e.ReceiverEmail, e.ReceiverFax, e.ReceiverFullname, e.ReceiverIdentification, e.ReceiverIssueCountry, e.ReceiverIssueDate, e.ReceiverJob, e.ReceiverMobile, e.ReceiverTaxCode, e.ReceiverTel, e.RemainingFreight, e.RemainingFreightDiscount, e.RemainingFreightDiscountVat, e.RemainingFreightVat, e.ReturnBeforeDate, e.ReturnDayNumber, e.SectionCode, e.SenderAddress, e.SenderAddressCode, e.SenderCustomReference, e.SenderDistrictCode, e.SenderEmail, e.SenderFax, e.SenderFullname, e.SenderIdentification, e.SenderIssueCountry, e.SenderIssueDate, e.SenderJob, e.SenderMobile, e.SenderTaxCode, e.SenderTel, e.SendingContent, e.CustomerCode, e.SendingTime })
                    .HasName("_dta_index_Item_5_123147484__K5_K18_1_2_3_4_6_7_8_9_10_11_12_13_14_15_16_17_19_20_21_22_23_24_25_26_27_28_29_30_31_32_33_34_35_");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AcceptancePoscode)
                    .IsRequired()
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AdviceOfReceiptCode).HasMaxLength(13);

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.Bc16index).HasColumnName("BC16Index");

                entity.Property(e => e.CertificateNumber).HasMaxLength(50);

                entity.Property(e => e.CheckContentOnDeliveryCode).HasMaxLength(13);

                entity.Property(e => e.CheckSum).HasMaxLength(1);

                entity.Property(e => e.Codaddress)
                    .HasColumnName("CODAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Codpayment).HasColumnName("CODPayment");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccountNo).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.CustomerGroupCode).HasMaxLength(20);

                entity.Property(e => e.DataCode).HasMaxLength(50);

                entity.Property(e => e.DecisionDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionNo).HasMaxLength(500);

                entity.Property(e => e.DeliveryNote).HasMaxLength(500);

                entity.Property(e => e.DestinationPoscode)
                    .HasColumnName("DestinationPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeRateCode).HasMaxLength(50);

                entity.Property(e => e.ExecuteOrder).HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.ItemNumber).HasMaxLength(50);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.OriginalPaymentFreightDiscountVat).HasColumnName("OriginalPaymentFreightDiscountVAT");

                entity.Property(e => e.OriginalPaymentFreightVat).HasColumnName("OriginalPaymentFreightVAT");

                entity.Property(e => e.OriginalRemainingFreightDiscountVat).HasColumnName("OriginalRemainingFreightDiscountVAT");

                entity.Property(e => e.OriginalRemainingFreightVat).HasColumnName("OriginalRemainingFreightVAT");

                entity.Property(e => e.OriginalTotalFreightDiscountVat).HasColumnName("OriginalTotalFreightDiscountVAT");

                entity.Property(e => e.OriginalTotalFreightVat).HasColumnName("OriginalTotalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.OtherAttachedInfor).HasMaxLength(100);

                entity.Property(e => e.PaymentFreightDiscountVat).HasColumnName("PaymentFreightDiscountVAT");

                entity.Property(e => e.PaymentFreightVat).HasColumnName("PaymentFreightVAT");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverCommuneCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverContact).HasMaxLength(100);

                entity.Property(e => e.ReceiverCustomReference).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverDistrictCode).HasMaxLength(4);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiverFax).HasMaxLength(15);

                entity.Property(e => e.ReceiverFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueCountry).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverJob).HasMaxLength(500);

                entity.Property(e => e.ReceiverMobile).HasMaxLength(15);

                entity.Property(e => e.ReceiverTaxCode).HasMaxLength(20);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.RemainingFreightDiscountVat).HasColumnName("RemainingFreightDiscountVAT");

                entity.Property(e => e.RemainingFreightVat).HasColumnName("RemainingFreightVAT");

                entity.Property(e => e.ReturnBeforeDate).HasColumnType("datetime");

                entity.Property(e => e.SectionCode).HasMaxLength(3);

                entity.Property(e => e.SenderAddress).HasMaxLength(500);

                entity.Property(e => e.SenderAddressCode).HasMaxLength(6);

                entity.Property(e => e.SenderCustomReference).HasMaxLength(500);

                entity.Property(e => e.SenderDistrictCode).HasMaxLength(4);

                entity.Property(e => e.SenderEmail).HasMaxLength(50);

                entity.Property(e => e.SenderFax).HasMaxLength(15);

                entity.Property(e => e.SenderFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SenderIdentification).HasMaxLength(50);

                entity.Property(e => e.SenderIssueCountry).HasMaxLength(50);

                entity.Property(e => e.SenderIssueDate).HasColumnType("datetime");

                entity.Property(e => e.SenderJob).HasMaxLength(500);

                entity.Property(e => e.SenderMobile).HasMaxLength(15);

                entity.Property(e => e.SenderTaxCode).HasMaxLength(20);

                entity.Property(e => e.SenderTel).HasMaxLength(15);

                entity.Property(e => e.SendingContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.TotalFreightDiscountVat).HasColumnName("TotalFreightDiscountVAT");

                entity.Property(e => e.TotalFreightVat).HasColumnName("TotalFreightVAT");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.Property(e => e.UndeliverableReason).HasMaxLength(500);

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_Item_Country");

                entity.HasOne(d => d.ExchangeRateCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ExchangeRateCode)
                    .HasConstraintName("FK_Item_ExchangeRate");

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Item_ItemType");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_Item_POS");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ProvinceCode)
                    .HasConstraintName("FK_Item_Province");

                entity.HasOne(d => d.ReceiverDistrictCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ReceiverDistrictCode)
                    .HasConstraintName("FK_Item_District");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_Item_Service");
            });

            modelBuilder.Entity<ItemAdviceOfReceipt>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.AdviceOfReceiptCode })
                    .HasName("PK_ItemAdviceOfReceipt");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AdviceOfReceiptCode).HasMaxLength(13);

                entity.Property(e => e.CheckContentOnDeliveryCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemChanged>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.HandoverIndex, e.ChangePoscode, e.ChangeIndex })
                    .HasName("PK_ItemChanged");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AcceptancePoscode)
                    .IsRequired()
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AdviceOfReceiptCode).HasMaxLength(13);

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.Bc16index).HasColumnName("BC16Index");

                entity.Property(e => e.CertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ChangeDateTime).HasColumnType("datetime");

                entity.Property(e => e.ChangeNote).HasMaxLength(500);

                entity.Property(e => e.CheckContentOnDeliveryCode).HasMaxLength(13);

                entity.Property(e => e.CheckSum).HasMaxLength(1);

                entity.Property(e => e.Codaddress)
                    .HasColumnName("CODAddress")
                    .HasMaxLength(200);

                entity.Property(e => e.Codamount).HasColumnName("CODAmount");

                entity.Property(e => e.Codfreight).HasColumnName("CODFreight");

                entity.Property(e => e.Codpayment).HasColumnName("CODPayment");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerAccountNo).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.CustomerGroupCode).HasMaxLength(20);

                entity.Property(e => e.DataCode).HasMaxLength(50);

                entity.Property(e => e.DecisionDate).HasColumnType("datetime");

                entity.Property(e => e.DecisionNo).HasMaxLength(500);

                entity.Property(e => e.DeliveryNote).HasMaxLength(500);

                entity.Property(e => e.DestinationPoscode)
                    .HasColumnName("DestinationPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeRateCode).HasMaxLength(50);

                entity.Property(e => e.ExecuteOrder).HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IsCod).HasColumnName("IsCOD");

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.IsPpa).HasColumnName("IsPPA");

                entity.Property(e => e.ItemNumber).HasMaxLength(50);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OldCodamount).HasColumnName("OldCODAmount");

                entity.Property(e => e.OldCodfreight).HasColumnName("OldCODFreight");

                entity.Property(e => e.OldCodvalue).HasColumnName("OldCODValue");

                entity.Property(e => e.OldIsCod).HasColumnName("OldIsCOD");

                entity.Property(e => e.OldIsPpa).HasColumnName("OldIsPPA");

                entity.Property(e => e.OldOriginalPaymentFreightDiscountVat).HasColumnName("OldOriginalPaymentFreightDiscountVAT");

                entity.Property(e => e.OldOriginalPaymentFreightVat).HasColumnName("OldOriginalPaymentFreightVAT");

                entity.Property(e => e.OldOriginalRemainingFreightDiscountVat).HasColumnName("OldOriginalRemainingFreightDiscountVAT");

                entity.Property(e => e.OldOriginalRemainingFreightVat).HasColumnName("OldOriginalRemainingFreightVAT");

                entity.Property(e => e.OldOriginalTotalFreightDiscountVat).HasColumnName("OldOriginalTotalFreightDiscountVAT");

                entity.Property(e => e.OldOriginalTotalFreightVat).HasColumnName("OldOriginalTotalFreightVAT");

                entity.Property(e => e.OldOriginalVatfreight).HasColumnName("OldOriginalVATFreight");

                entity.Property(e => e.OldOriginalVatpercentage).HasColumnName("OldOriginalVATPercentage");

                entity.Property(e => e.OldPaymentFreightDiscountVat).HasColumnName("OldPaymentFreightDiscountVAT");

                entity.Property(e => e.OldPaymentFreightVat).HasColumnName("OldPaymentFreightVAT");

                entity.Property(e => e.OldRemainingFreightDiscountVat).HasColumnName("OldRemainingFreightDiscountVAT");

                entity.Property(e => e.OldRemainingFreightVat).HasColumnName("OldRemainingFreightVAT");

                entity.Property(e => e.OldTotalFreightDiscountVat).HasColumnName("OldTotalFreightDiscountVAT");

                entity.Property(e => e.OldTotalFreightVat).HasColumnName("OldTotalFreightVAT");

                entity.Property(e => e.OldVatfreight).HasColumnName("OldVATFreight");

                entity.Property(e => e.OldVatpercentage).HasColumnName("OldVATPercentage");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.OriginalPaymentFreightDiscountVat).HasColumnName("OriginalPaymentFreightDiscountVAT");

                entity.Property(e => e.OriginalPaymentFreightVat).HasColumnName("OriginalPaymentFreightVAT");

                entity.Property(e => e.OriginalRemainingFreightDiscountVat).HasColumnName("OriginalRemainingFreightDiscountVAT");

                entity.Property(e => e.OriginalRemainingFreightVat).HasColumnName("OriginalRemainingFreightVAT");

                entity.Property(e => e.OriginalTotalFreightDiscountVat).HasColumnName("OriginalTotalFreightDiscountVAT");

                entity.Property(e => e.OriginalTotalFreightVat).HasColumnName("OriginalTotalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.OtherAttachedInfor).HasMaxLength(100);

                entity.Property(e => e.PaymentFreightDiscountVat).HasColumnName("PaymentFreightDiscountVAT");

                entity.Property(e => e.PaymentFreightVat).HasColumnName("PaymentFreightVAT");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverCommuneCode).HasMaxLength(6);

                entity.Property(e => e.ReceiverContact).HasMaxLength(100);

                entity.Property(e => e.ReceiverCustomReference).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverDistrictCode).HasMaxLength(4);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiverFax).HasMaxLength(15);

                entity.Property(e => e.ReceiverFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueCountry).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverJob).HasMaxLength(500);

                entity.Property(e => e.ReceiverMobile).HasMaxLength(15);

                entity.Property(e => e.ReceiverTaxCode).HasMaxLength(20);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.RemainingFreightDiscountVat).HasColumnName("RemainingFreightDiscountVAT");

                entity.Property(e => e.RemainingFreightVat).HasColumnName("RemainingFreightVAT");

                entity.Property(e => e.ReturnBeforeDate).HasColumnType("datetime");

                entity.Property(e => e.SectionCode).HasMaxLength(3);

                entity.Property(e => e.SenderAddress).HasMaxLength(500);

                entity.Property(e => e.SenderAddressCode).HasMaxLength(6);

                entity.Property(e => e.SenderCustomReference).HasMaxLength(500);

                entity.Property(e => e.SenderDistrictCode).HasMaxLength(4);

                entity.Property(e => e.SenderEmail).HasMaxLength(50);

                entity.Property(e => e.SenderFax).HasMaxLength(15);

                entity.Property(e => e.SenderFullname)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SenderIdentification).HasMaxLength(50);

                entity.Property(e => e.SenderIssueCountry).HasMaxLength(50);

                entity.Property(e => e.SenderIssueDate).HasColumnType("datetime");

                entity.Property(e => e.SenderJob).HasMaxLength(500);

                entity.Property(e => e.SenderMobile).HasMaxLength(15);

                entity.Property(e => e.SenderTaxCode).HasMaxLength(20);

                entity.Property(e => e.SenderTel).HasMaxLength(15);

                entity.Property(e => e.SendingContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.TotalFreightDiscountVat).HasColumnName("TotalFreightDiscountVAT");

                entity.Property(e => e.TotalFreightVat).HasColumnName("TotalFreightVAT");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.Property(e => e.UndeliverableReason).HasMaxLength(500);

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");
            });

            modelBuilder.Entity<ItemChangedReason>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ChangeReasonCode })
                    .HasName("PK_ItemChangedReason");

                entity.Property(e => e.ItemCode).HasMaxLength(13);
            });

            modelBuilder.Entity<ItemCommodityType>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.CommodityTypeCode })
                    .HasName("PK_ItemCommodityType");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.CommodityTypeCodeNavigation)
                    .WithMany(p => p.ItemCommodityType)
                    .HasForeignKey(d => d.CommodityTypeCode)
                    .HasConstraintName("FK_ItemCommodityType_CommodityType");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ItemCommodityType)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ItemCommodityType_Item");
            });

            modelBuilder.Entity<ItemCommodityTypeChanged>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ChangeIndex, e.HandoverIndex, e.ChangePoscode, e.CommodityTypeCode })
                    .HasName("PK_ItemCommodityTypeChanged");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.ItemCommodityTypeChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemCommodityTypeChanged_ItemChanged");
            });

            modelBuilder.Entity<ItemCompensate>(entity =>
            {
                entity.HasKey(e => e.ItemCode)
                    .HasName("PK_ItemCompensate");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CompensateDate).HasColumnType("datetime");

                entity.Property(e => e.CompensatePoscode)
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CompensateReason).HasMaxLength(2000);

                entity.Property(e => e.CompensateUsername).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithOne(p => p.ItemCompensate)
                    .HasForeignKey<ItemCompensate>(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemCompensate_Item");
            });

            modelBuilder.Entity<ItemForward>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ForwardDate })
                    .HasName("PK_ItemForward");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ForwardDate).HasColumnType("datetime");

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.Property(e => e.CommuneCodeOld).HasMaxLength(6);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CountryCodeOld).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.Property(e => e.DistrictCodeOld).HasMaxLength(4);

                entity.Property(e => e.ForwardPoscode)
                    .HasColumnName("ForwardPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FreightVat).HasColumnName("FreightVAT");

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OriginalFreightVat).HasColumnName("OriginalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PoscodeOld)
                    .HasColumnName("POSCodeOld")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvinceCode).HasMaxLength(2);

                entity.Property(e => e.ProvinceCodeOld).HasMaxLength(2);

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverAddressCodeOld).HasMaxLength(6);

                entity.Property(e => e.ReceiverAddressOld).HasMaxLength(500);

                entity.Property(e => e.ReceiverContactOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(100);

                entity.Property(e => e.ReceiverEmailOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverFaxOld).HasMaxLength(15);

                entity.Property(e => e.ReceiverFullname).HasMaxLength(500);

                entity.Property(e => e.ReceiverFullnameOld).HasMaxLength(500);

                entity.Property(e => e.ReceiverIdentificationOld).HasMaxLength(50);

                entity.Property(e => e.ReceiverMobileOld).HasMaxLength(15);

                entity.Property(e => e.ReceiverTaxCodeOld).HasMaxLength(20);

                entity.Property(e => e.ReceiverTel).HasMaxLength(50);

                entity.Property(e => e.ReceiverTelOld).HasMaxLength(15);

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ItemForward)
                    .HasForeignKey(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemForward_Item");
            });

            modelBuilder.Entity<ItemInventory>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.HandoverIndex, e.ShiftCode, e.CounterCode, e.Poscode, e.Status })
                    .HasName("PK_ItemInventory");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);
            });

            modelBuilder.Entity<ItemPropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.PropertyCode })
                    .HasName("PK_ItemPropertyValue");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ItemPropertyValue)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ItemPropertyValue_Item");

                entity.HasOne(d => d.PropertyCodeNavigation)
                    .WithMany(p => p.ItemPropertyValue)
                    .HasForeignKey(d => d.PropertyCode)
                    .HasConstraintName("FK_ItemPropertyValue_Property");
            });

            modelBuilder.Entity<ItemPropertyValueChanged>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ChangeIndex, e.HandoverIndex, e.ChangePoscode, e.PropertyCode })
                    .HasName("PK_ItemPropertyValueChanged");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.ItemPropertyValueChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemPropertyValueChanged_ItemChanged");
            });

            modelBuilder.Entity<ItemReturn>(entity =>
            {
                entity.HasKey(e => e.ItemCode)
                    .HasName("PK_ItemReturn");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FreightVat).HasColumnName("FreightVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OriginalFreightVat).HasColumnName("OriginalFreightVAT");

                entity.Property(e => e.OriginalVatfreight).HasColumnName("OriginalVATFreight");

                entity.Property(e => e.OriginalVatpercentage).HasColumnName("OriginalVATPercentage");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Reason).HasMaxLength(500);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverFullname).HasMaxLength(500);

                entity.Property(e => e.ReceiverTel).HasMaxLength(50);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnFreightVatcustomer).HasColumnName("ReturnFreightVATCustomer");

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithOne(p => p.ItemReturn)
                    .HasForeignKey<ItemReturn>(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemReturn_Item");
            });

            modelBuilder.Entity<ItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeCode)
                    .HasName("PK_ItemType");

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.ItemTypeName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ItemTypeNotUsedValueAddedService>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ItemTypeCode, e.ValueAddedServiceCode })
                    .HasName("PK_ItemTypeNotUsedValueAddedService");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(6);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(6);
            });

            modelBuilder.Entity<ItemTypeUsedValueAddedService>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ItemTypeCode, e.ValueAddedServiceCode })
                    .HasName("PK_ItemTypeUsingValueAddedService");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(6);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(6);
            });

            modelBuilder.Entity<ItemVaspropertyValue>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.PropertyCode, e.ValueAddedServiceCode })
                    .HasName("PK_ItemVASPropertyValue");

                entity.ToTable("ItemVASPropertyValue");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ItemVaspropertyValue)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ItemVASPropertyValue_Item");

                entity.HasOne(d => d.Vasproperty)
                    .WithMany(p => p.ItemVaspropertyValue)
                    .HasForeignKey(d => new { d.PropertyCode, d.ValueAddedServiceCode })
                    .HasConstraintName("FK_ItemVASPropertyValue_VASProperty");
            });

            modelBuilder.Entity<ItemVaspropertyValueChanged>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.ChangeIndex, e.HandoverIndex, e.ChangePoscode, e.PropertyCode, e.ValueAddedServiceCode })
                    .HasName("PK_ItemVASPropertyValueChanged");

                entity.ToTable("ItemVASPropertyValueChanged");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.ItemVaspropertyValueChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ItemVASPropertyValueChanged_ItemChanged");
            });

            modelBuilder.Entity<LetterMoneyOrder>(entity =>
            {
                entity.HasKey(e => new { e.LetterMoneyOrderCode, e.LetterMoneyOrderRuleCode, e.ServiceCode })
                    .HasName("PK_LetterMoneyOrder");

                entity.Property(e => e.LetterMoneyOrderCode).HasMaxLength(10);

                entity.Property(e => e.LetterMoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.LetterMoneyOrderRule)
                    .WithMany(p => p.LetterMoneyOrder)
                    .HasForeignKey(d => new { d.LetterMoneyOrderRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_LetterMoneyOrder_LetterMoneyOrderRule1");
            });

            modelBuilder.Entity<LetterMoneyOrderRule>(entity =>
            {
                entity.HasKey(e => new { e.LetterMoneyOrderRuleCode, e.ServiceCode })
                    .HasName("PK_LetterMoneyOrderRule");

                entity.HasIndex(e => e.LetterMoneyOrderRuleCode)
                    .HasName("IX_LetterMoneyOrderRule_ValueDate");

                entity.Property(e => e.LetterMoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RuleNo).HasMaxLength(100);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.LetterMoneyOrderRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_LetterMoneyOrderRule_Service");
            });

            modelBuilder.Entity<LicenseInformation>(entity =>
            {
                entity.HasKey(e => e.LicenseId)
                    .HasName("PK_LicenseInformation");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PublicKey)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LicenseStorage>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_LicenseStorage");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Posname)
                    .IsRequired()
                    .HasColumnName("POSName")
                    .HasMaxLength(300);

                entity.Property(e => e.PrivateKey)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PublicKey)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LimitWeight>(entity =>
            {
                entity.HasKey(e => new { e.CountryCode, e.ServiceCode })
                    .HasName("PK_LimitWeight");

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.LimitWeight)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_LimitWeight_Country");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.LimitWeight)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_LimitWeight_Service");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => new { e.LogIndex, e.Poscode })
                    .HasName("PK_Log");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.LogContent).HasMaxLength(500);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Log)
                    .HasForeignKey(d => new { d.Username, d.Poscode })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Log_User");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => new { e.MachineCode, e.CounterCode, e.Poscode })
                    .HasName("PK_Machine");

                entity.Property(e => e.MachineCode).HasMaxLength(3);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MachineIp)
                    .HasColumnName("MachineIP")
                    .HasMaxLength(50);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Counter)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => new { d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_Machine_Counter");
            });

            modelBuilder.Entity<MailRoute>(entity =>
            {
                entity.HasKey(e => new { e.MailRouteCode, e.FromPoscode })
                    .HasName("PK_MailRoute");

                entity.HasIndex(e => new { e.FromPoscode, e.MailRouteCode })
                    .HasName("_dta_index_MailRoute_6_571149080__K6_K1");

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MailRouteName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MailRouteTypeCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.HasOne(d => d.FromPoscodeNavigation)
                    .WithMany(p => p.MailRoute)
                    .HasForeignKey(d => d.FromPoscode)
                    .HasConstraintName("FK_MailRoute_POS");

                entity.HasOne(d => d.MailRouteTypeCodeNavigation)
                    .WithMany(p => p.MailRoute)
                    .HasForeignKey(d => d.MailRouteTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MailRoute_MailRouteType");

                entity.HasOne(d => d.TransportTypeCodeNavigation)
                    .WithMany(p => p.MailRoute)
                    .HasForeignKey(d => d.TransportTypeCode)
                    .HasConstraintName("FK_MailRoute_TransportType");
            });

            modelBuilder.Entity<MailRoutePos>(entity =>
            {
                entity.HasKey(e => new { e.MailRouteCode, e.FromPoscode, e.OnMailRoutePoscode, e.MailRouteScheduleCode, e.Type })
                    .HasName("PK_MailRoutePOS");

                entity.ToTable("MailRoutePOS");

                entity.HasIndex(e => new { e.MailRouteCode, e.FromPoscode })
                    .HasName("_dta_index_MailRoutePOS_5_507148852__K1_K2");

                entity.HasIndex(e => new { e.FromPoscode, e.MailRouteCode, e.OnMailRoutePoscode })
                    .HasName("_dta_index_MailRoutePOS_6_539148966__K2_K1_K3");

                entity.HasIndex(e => new { e.MailRouteCode, e.FromPoscode, e.OnMailRoutePoscode })
                    .HasName("_dta_index_MailRoutePOS_6_539148966__K1_K2_K3");

                entity.HasIndex(e => new { e.OnMailRoutePoscode, e.FromPoscode, e.MailRouteCode })
                    .HasName("_dta_index_MailRoutePOS_6_539148966__K3_K2_K1");

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.OnMailRoutePoscode)
                    .HasColumnName("OnMailRoutePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailRouteScheduleCode).HasMaxLength(5);

                entity.Property(e => e.IncomingTime).HasColumnType("datetime");

                entity.Property(e => e.OutgoingTime).HasColumnType("datetime");

                entity.Property(e => e.Posorder).HasColumnName("POSOrder");

                entity.HasOne(d => d.OnMailRoutePoscodeNavigation)
                    .WithMany(p => p.MailRoutePos)
                    .HasForeignKey(d => d.OnMailRoutePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MailRoutePOS_POS1");
            });

            modelBuilder.Entity<MailRouteSchedule>(entity =>
            {
                entity.HasKey(e => new { e.MailRouteScheduleCode, e.MailRouteCode, e.FromPoscode })
                    .HasName("PK_MailRouteSchedule");

                entity.HasIndex(e => new { e.MailRouteScheduleCode, e.MailRouteScheduleName, e.Description, e.FromPoscode, e.MailRouteCode })
                    .HasName("_dta_index_MailRouteSchedule_5_907150277__K3_K2_1_4_5");

                entity.Property(e => e.MailRouteScheduleCode).HasMaxLength(5);

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MailRouteScheduleName).HasMaxLength(500);

                entity.HasOne(d => d.MailRoute)
                    .WithMany(p => p.MailRouteSchedule)
                    .HasForeignKey(d => new { d.MailRouteCode, d.FromPoscode })
                    .HasConstraintName("FK_MailRouteSchedule_MailRoute");
            });

            modelBuilder.Entity<MailRouteService>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.MailRouteCode, e.FromPoscode })
                    .HasName("PK_MailRouteService");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.MailRouteService)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_MailRouteService_Service");

                entity.HasOne(d => d.MailRoute)
                    .WithMany(p => p.MailRouteService)
                    .HasForeignKey(d => new { d.MailRouteCode, d.FromPoscode })
                    .HasConstraintName("FK_MailRouteService_MailRoute");
            });

            modelBuilder.Entity<MailRouteType>(entity =>
            {
                entity.HasKey(e => e.MailRouteTypeCode)
                    .HasName("PK_MailRouteType");

                entity.Property(e => e.MailRouteTypeCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MailRouteTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Mailtrip>(entity =>
            {
                entity.HasKey(e => new { e.StartingCode, e.DestinationCode, e.MailtripType, e.ServiceCode, e.Year, e.MailtripNumber })
                    .HasName("PK_Mailtrip_1");

                entity.HasIndex(e => e.MailRouteCode)
                    .HasName("IX_Mailtrip_MailRouteCode");

                entity.HasIndex(e => e.OpeningTime)
                    .HasName("IX_Mailtrip_OpeningTime");

                entity.HasIndex(e => e.OutgoingDate)
                    .HasName("IX_Mailtrip_OutgoingDate");

                entity.HasIndex(e => e.PackagingTime)
                    .HasName("IX_Mailtrip_PackingTime");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Mailtrip_Status");

                entity.HasIndex(e => e.TrasferTime)
                    .HasName("IX_Mailtrip_TransferTime");

                entity.Property(e => e.StartingCode).HasMaxLength(6);

                entity.Property(e => e.DestinationCode).HasMaxLength(6);

                entity.Property(e => e.MailtripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailtripNumber).HasMaxLength(4);

                entity.Property(e => e.Bc37number)
                    .HasColumnName("BC37Number")
                    .HasMaxLength(4);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryRoute).HasMaxLength(10);

                entity.Property(e => e.IncomingDate).HasColumnType("datetime");

                entity.Property(e => e.InitialMachineName).HasMaxLength(50);

                entity.Property(e => e.InitialTime).HasColumnType("datetime");

                entity.Property(e => e.InitialUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode).HasMaxLength(10);

                entity.Property(e => e.OpeningMachineName).HasMaxLength(50);

                entity.Property(e => e.OpeningTime).HasColumnType("datetime");

                entity.Property(e => e.OpeningUser).HasMaxLength(50);

                entity.Property(e => e.OriginalTransportPoscode)
                    .HasColumnName("OriginalTransportPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.OutgoingDate).HasColumnType("datetime");

                entity.Property(e => e.PackagingMachineName).HasMaxLength(50);

                entity.Property(e => e.PackagingTime).HasMaxLength(50);

                entity.Property(e => e.PackagingUser).HasMaxLength(50);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferId)
                    .HasColumnName("TransferID")
                    .HasMaxLength(50);

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportNumber).HasMaxLength(3);

                entity.Property(e => e.TrasferTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MailtripItem>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.FromPoscode, e.ToPoscode, e.MailtripType, e.ServiceCode, e.ExtendServiceCode, e.Year, e.MailtripNumber })
                    .HasName("PK_MailTripItem");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_MailtripItem_Status");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailtripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(1);

                entity.Property(e => e.ExtendServiceCode).HasMaxLength(1);

                entity.Property(e => e.Year).HasMaxLength(1);

                entity.Property(e => e.MailtripNumber).HasMaxLength(4);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.MailtripItem)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_MailTripItem_Item");
            });

            modelBuilder.Entity<MailtripTransport>(entity =>
            {
                entity.HasKey(e => new { e.FromPoscode, e.TransportDate, e.TransportCode, e.TransportNumber })
                    .HasName("PK_MailtripTransport_1");

                entity.HasIndex(e => e.GoingDate)
                    .HasName("IX_MailtripTransport_GoingDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_MailtripTransport_Status");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.Property(e => e.CommandContent).HasMaxLength(500);

                entity.Property(e => e.CommandDate).HasColumnType("datetime");

                entity.Property(e => e.CommandNumber).HasMaxLength(50);

                entity.Property(e => e.ConfirmUsser).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.DestinationCode).HasMaxLength(10);

                entity.Property(e => e.DriverCode).HasMaxLength(50);

                entity.Property(e => e.EcortCode).HasMaxLength(50);

                entity.Property(e => e.GoingDate).HasColumnType("datetime");

                entity.Property(e => e.InitialDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MailRouteCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MailRouteScheduleCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.StartingCode).HasMaxLength(10);

                entity.Property(e => e.TransportAffairCode).HasMaxLength(50);

                entity.HasOne(d => d.TransportCodeNavigation)
                    .WithMany(p => p.MailtripTransport)
                    .HasForeignKey(d => d.TransportCode)
                    .HasConstraintName("FK_MailtripTransport_Transport");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.MailtripTransport)
                    .HasForeignKey(d => new { d.DriverCode, d.FromPoscode })
                    .HasConstraintName("FK_MailtripTransport_Driver");

                entity.HasOne(d => d.MailRouteSchedule)
                    .WithMany(p => p.MailtripTransport)
                    .HasForeignKey(d => new { d.MailRouteScheduleCode, d.MailRouteCode, d.FromPoscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MailtripTransport_MailRouteSchedule");
            });

            modelBuilder.Entity<MailtripTransportBc37>(entity =>
            {
                entity.HasKey(e => new { e.Bc37date, e.Bc37index, e.Bc37fromPoscode, e.Bc37toPoscode, e.TransportTypeCode, e.MailtripTransportFromPoscode, e.TransportDate, e.TransportCode, e.TransportNumber })
                    .HasName("PK_MailtripTransportBC37");

                entity.ToTable("MailtripTransportBC37");

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.Bc37fromPoscode)
                    .HasColumnName("BC37FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc37toPoscode)
                    .HasColumnName("BC37ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.MailtripTransportFromPoscode)
                    .HasColumnName("MailtripTransportFromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.Property(e => e.Bc37order).HasColumnName("BC37Order");

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmPoscode)
                    .HasColumnName("ConfirmPOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmUser).HasMaxLength(50);

                entity.Property(e => e.CreatePoscode)
                    .HasColumnName("CreatePOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.MailtripTransport)
                    .WithMany(p => p.MailtripTransportBc37)
                    .HasForeignKey(d => new { d.MailtripTransportFromPoscode, d.TransportDate, d.TransportCode, d.TransportNumber })
                    .HasConstraintName("FK_MailtripTransportBC37_MailtripTransport");

                entity.HasOne(d => d.Bc37)
                    .WithMany(p => p.MailtripTransportBc37)
                    .HasForeignKey(d => new { d.Bc37index, d.Bc37fromPoscode, d.Bc37toPoscode, d.TransportTypeCode, d.Bc37date })
                    .HasConstraintName("FK_MailtripTransportBC37_BC37");
            });

            modelBuilder.Entity<MailtripTransportPostBag>(entity =>
            {
                entity.HasKey(e => new { e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailtripType, e.ServiceCode, e.Year, e.MailTripNumber, e.Bc37index, e.Bc37fromPoscode, e.Bc37date, e.Bc37toPoscode, e.TransportTypeCode })
                    .HasName("PK_MailtripTransportPostBag");

                entity.HasIndex(e => new { e.Bc37index, e.Bc37fromPoscode, e.TransportTypeCode, e.Bc37date, e.Bc37toPoscode, e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailtripType, e.ServiceCode, e.Year, e.MailTripNumber })
                    .HasName("_dta_index_MailtripTransportPostBag_6_1662628966__K9_K10_K13_K11_K12_K1_K2_K3_K4_K5_K6_K7");

                entity.HasIndex(e => new { e.FromPoscode, e.MailTripNumber, e.MailtripType, e.PostBagIndex, e.ServiceCode, e.Status, e.ToPoscode, e.Bc37order, e.Year, e.Bc37fromPoscode, e.Bc37toPoscode, e.TransportTypeCode, e.Bc37date, e.Bc37index })
                    .HasName("_dta_index_MailtripTransportPostBag_5_1630628852__K10_K12_K13_K11_K9_1_2_3_4_5_6_7_8_14");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailtripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.Bc37fromPoscode)
                    .HasColumnName("BC37FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37toPoscode)
                    .HasColumnName("BC37ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.Bc37order).HasColumnName("BC37Order");

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmPoscode)
                    .HasColumnName("ConfirmPOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmUser).HasMaxLength(50);

                entity.Property(e => e.CreatePoscode)
                    .HasColumnName("CreatePOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Bc37)
                    .WithMany(p => p.MailtripTransportPostBag)
                    .HasForeignKey(d => new { d.Bc37index, d.Bc37fromPoscode, d.Bc37toPoscode, d.TransportTypeCode, d.Bc37date })
                    .HasConstraintName("FK_MailtripTransportPostBag_BC37");

                entity.HasOne(d => d.PostBag)
                    .WithMany(p => p.MailtripTransportPostBag)
                    .HasForeignKey(d => new { d.PostBagIndex, d.FromPoscode, d.ToPoscode, d.MailtripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_MailtripTransportPostBag_PostBag");
            });

            modelBuilder.Entity<MailtripTransportPostBagLog>(entity =>
            {
                entity.HasKey(e => e.MailtripTransportPostBagLogCode)
                    .HasName("PK_MailtripTransportPostBagLog");

                entity.Property(e => e.MailtripTransportPostBagLogCode).HasMaxLength(12);

                entity.Property(e => e.Bc37date)
                    .IsRequired()
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37fromPoscode)
                    .IsRequired()
                    .HasColumnName("BC37FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.Bc37order).HasColumnName("BC37Order");

                entity.Property(e => e.Bc37toPoscode)
                    .IsRequired()
                    .HasColumnName("BC37ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ConfirmDate).HasColumnType("datetime");

                entity.Property(e => e.ConfirmPoscode)
                    .HasColumnName("ConfirmPOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmUser).HasMaxLength(50);

                entity.Property(e => e.CreatePoscode)
                    .HasColumnName("CreatePOSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreateUser).HasMaxLength(50);

                entity.Property(e => e.FromPoscode)
                    .IsRequired()
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LogContent).HasMaxLength(500);

                entity.Property(e => e.LogCreator).HasMaxLength(100);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.MailTripNumber)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MailtripType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ToPoscode)
                    .IsRequired()
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportTypeCode)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<MailtripTransportTrace>(entity =>
            {
                entity.HasKey(e => new { e.MailtripTransportTraceIndex, e.Poscode, e.FromPoscode, e.TransportDate, e.TransportCode, e.TransportNumber })
                    .HasName("PK_MailtripTransportTrace");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.TraceDate).HasColumnType("datetime");

                entity.Property(e => e.TraceDescription).HasColumnType("nchar(10)");

                entity.HasOne(d => d.MailtripTransport)
                    .WithMany(p => p.MailtripTransportTrace)
                    .HasForeignKey(d => new { d.FromPoscode, d.TransportDate, d.TransportCode, d.TransportNumber })
                    .HasConstraintName("FK_MailtripTransportTrace_MailtripTransport");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.MenuCode)
                    .HasName("PK_Menu");

                entity.Property(e => e.MenuCode).HasMaxLength(10);

                entity.Property(e => e.DllName).HasMaxLength(200);

                entity.Property(e => e.FormName).HasMaxLength(200);

                entity.Property(e => e.Image).HasMaxLength(200);

                entity.Property(e => e.MenuName).HasMaxLength(200);

                entity.Property(e => e.NameSpace).HasMaxLength(200);

                entity.Property(e => e.ParentMenuCode).HasMaxLength(10);

                entity.Property(e => e.Script).HasColumnType("ntext");

                entity.Property(e => e.ShortcutKey).HasMaxLength(2);

                entity.HasOne(d => d.ParentMenuCodeNavigation)
                    .WithMany(p => p.InverseParentMenuCodeNavigation)
                    .HasForeignKey(d => d.ParentMenuCode)
                    .HasConstraintName("FK_Menu_Menu");
            });

            modelBuilder.Entity<MenuParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterCode)
                    .HasName("PK_MenuParameter");

                entity.Property(e => e.ParameterCode).HasMaxLength(10);

                entity.Property(e => e.MenuCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParameterValue)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.MenuCodeNavigation)
                    .WithMany(p => p.MenuParameter)
                    .HasForeignKey(d => d.MenuCode)
                    .HasConstraintName("FK_MenuParameter_Menu");
            });

            modelBuilder.Entity<MenuService>(entity =>
            {
                entity.HasKey(e => new { e.MenuCode, e.ServiceCode })
                    .HasName("PK_MenuService");

                entity.Property(e => e.MenuCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.MenuCodeNavigation)
                    .WithMany(p => p.MenuService)
                    .HasForeignKey(d => d.MenuCode)
                    .HasConstraintName("FK_MenuService_Menu");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.MenuService)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_MenuService_Service");
            });

            modelBuilder.Entity<MenuVersion>(entity =>
            {
                entity.HasKey(e => new { e.MenuCode, e.VersionCode })
                    .HasName("PK_MenuVersion");

                entity.Property(e => e.MenuCode).HasMaxLength(10);

                entity.Property(e => e.VersionCode).HasMaxLength(10);

                entity.HasOne(d => d.MenuCodeNavigation)
                    .WithMany(p => p.MenuVersion)
                    .HasForeignKey(d => d.MenuCode)
                    .HasConstraintName("FK_MenuVersion_Menu");

                entity.HasOne(d => d.VersionCodeNavigation)
                    .WithMany(p => p.MenuVersion)
                    .HasForeignKey(d => d.VersionCode)
                    .HasConstraintName("FK_MenuVersion_Version");
            });

            modelBuilder.Entity<MessageType>(entity =>
            {
                entity.HasKey(e => e.MessageTypeName)
                    .HasName("PK_MessageType_1");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);
            });

            modelBuilder.Entity<MessageTypeLastCall>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.MessageTypeName })
                    .HasName("PK_DomesticFreightRuleLastCall");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MessageTypeName).HasMaxLength(50);

                entity.Property(e => e.LastCall).HasColumnType("datetime");
            });

            modelBuilder.Entity<MessageTypeTable>(entity =>
            {
                entity.HasKey(e => new { e.MessageTypeName, e.TableName })
                    .HasName("PK_MessageTypeTable");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.ClientUpdateSql).HasMaxLength(100);

/*                entity.HasOne(d => d.GetType)
                    .WithMany(p => p.MessageTypeTable)
                    .HasForeignKey(d => d.GetTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageTypeTable_GetType");*/

                entity.HasOne(d => d.MessageTypeNameNavigation)
                    .WithMany(p => p.MessageTypeTable)
                    .HasForeignKey(d => d.MessageTypeName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageTypeTable_MessageType");

                entity.HasOne(d => d.StoreBehavior)
                    .WithMany(p => p.MessageTypeTable)
                    .HasForeignKey(d => d.StoreBehaviorId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageTypeTable_StoreBehavior");

                entity.HasOne(d => d.StoreType)
                    .WithMany(p => p.MessageTypeTable)
                    .HasForeignKey(d => d.StoreTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageTypeTable_StoreType");

                entity.HasOne(d => d.TableNameNavigation)
                    .WithMany(p => p.MessageTypeTable)
                    .HasForeignKey(d => d.TableName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MessageTypeTable_Table");
            });

            modelBuilder.Entity<MoneyOrderRule>(entity =>
            {
                entity.HasKey(e => new { e.MoneyOrderRuleCode, e.DomesticFreightRuleCode, e.ItemTypeCode, e.ServiceCode })
                    .HasName("PK_MoneyOrderRule");

                entity.Property(e => e.MoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNo).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MoneyOrderStep>(entity =>
            {
                entity.HasKey(e => new { e.MoneyOrderRuleCode, e.MoneyOrderStepCode, e.DomesticFreightRuleCode, e.ItemTypeCode, e.ServiceCode })
                    .HasName("PK_MoneyOrderStep");

                entity.Property(e => e.MoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.MoneyOrderStepCode).HasMaxLength(10);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.IsBatch).HasColumnName("isBatch");

                entity.HasOne(d => d.MoneyOrderRule)
                    .WithMany(p => p.MoneyOrderStep)
                    .HasForeignKey(d => new { d.MoneyOrderRuleCode, d.DomesticFreightRuleCode, d.ItemTypeCode, d.ServiceCode })
                    .HasConstraintName("FK_MoneyOrderStep_MoneyOrderRule");
            });

            modelBuilder.Entity<MoneyOrderValueAddedService>(entity =>
            {
                entity.HasKey(e => new { e.ValueAddedServiceCode, e.MoneyOrderRuleCode, e.DomesticFreightRuleCode, e.ItemTypeCode, e.ServiceCode })
                    .HasName("PK_MoneyOrderValueAddedService");

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.MoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.ValueAddedServiceCodeNavigation)
                    .WithMany(p => p.MoneyOrderValueAddedService)
                    .HasForeignKey(d => d.ValueAddedServiceCode)
                    .HasConstraintName("FK_MoneyOrderValueAddedService_ValueAddedService");

                entity.HasOne(d => d.MoneyOrderRule)
                    .WithMany(p => p.MoneyOrderValueAddedService)
                    .HasForeignKey(d => new { d.MoneyOrderRuleCode, d.DomesticFreightRuleCode, d.ItemTypeCode, d.ServiceCode })
                    .HasConstraintName("FK_MoneyOrderValueAddedService_MoneyOrderRule");
            });

            modelBuilder.Entity<MoneyOrderValueAddedServiceSingeItem>(entity =>
            {
                entity.HasKey(e => new { e.ValueAddedServiceCode, e.MoneyOrderRuleCode, e.MoneyOrderValueAddedServiceSingeItemCode, e.DomesticFreightRuleCode, e.ItemTypeCode, e.ServiceCode })
                    .HasName("PK_MoneyOrderValueAddedServiceSingeItem");

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.MoneyOrderRuleCode).HasMaxLength(10);

                entity.Property(e => e.MoneyOrderValueAddedServiceSingeItemCode).HasMaxLength(10);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.MoneyOrderValueAddedService)
                    .WithMany(p => p.MoneyOrderValueAddedServiceSingeItem)
                    .HasForeignKey(d => new { d.ValueAddedServiceCode, d.MoneyOrderRuleCode, d.DomesticFreightRuleCode, d.ItemTypeCode, d.ServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MoneyOrderValueAddedServiceSingeItem_MoneyOrderValueAddedService");
            });

            modelBuilder.Entity<NearProvince>(entity =>
            {
                entity.HasKey(e => new { e.ProvinceCode, e.RegionCode })
                    .HasName("PK_NearProvince");

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.RegionCode).HasMaxLength(2);

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.NearProvince)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NearProvince_Province");

                entity.HasOne(d => d.RegionCodeNavigation)
                    .WithMany(p => p.NearProvince)
                    .HasForeignKey(d => d.RegionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NearProvince_Region");
            });

            modelBuilder.Entity<NearRegion>(entity =>
            {
                entity.HasKey(e => new { e.OriginalRegionCode, e.NearRegionCode })
                    .HasName("PK_NearRegion");

                entity.Property(e => e.OriginalRegionCode).HasMaxLength(2);

                entity.Property(e => e.NearRegionCode).HasMaxLength(2);

                entity.HasOne(d => d.NearRegionCodeNavigation)
                    .WithMany(p => p.NearRegionNearRegionCodeNavigation)
                    .HasForeignKey(d => d.NearRegionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NearRegion_Region1");

                entity.HasOne(d => d.OriginalRegionCodeNavigation)
                    .WithMany(p => p.NearRegionOriginalRegionCodeNavigation)
                    .HasForeignKey(d => d.OriginalRegionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NearRegion_Region");
            });

            modelBuilder.Entity<Node>(entity =>
            {
                entity.HasKey(e => e.NodeName)
                    .HasName("PK_Node");

                entity.Property(e => e.NodeName).HasMaxLength(50);

                entity.Property(e => e.DnsIdentity).HasMaxLength(50);

                entity.Property(e => e.HttpAddress).HasMaxLength(50);

                entity.Property(e => e.HttpsAddress).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.MsmqAddress).HasMaxLength(50);

                entity.Property(e => e.NetTcpAddress).HasMaxLength(50);

                entity.Property(e => e.QueueName).HasMaxLength(50);
            });

            modelBuilder.Entity<NodeToNode>(entity =>
            {
                entity.HasKey(e => new { e.FromNodeName, e.ToNodeName })
                    .HasName("PK_NodeToNode");

                entity.Property(e => e.FromNodeName).HasMaxLength(50);

                entity.Property(e => e.ToNodeName).HasMaxLength(50);

                entity.HasOne(d => d.FromNodeNameNavigation)
                    .WithMany(p => p.NodeToNodeFromNodeNameNavigation)
                    .HasForeignKey(d => d.FromNodeName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NodeToNode_Node");

                entity.HasOne(d => d.ToNodeNameNavigation)
                    .WithMany(p => p.NodeToNodeToNodeNameNavigation)
                    .HasForeignKey(d => d.ToNodeName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_NodeToNode_Node1");
            });

            modelBuilder.Entity<ObjectRef>(entity =>
            {
                entity.Property(e => e.ObjectRefId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Enable).HasDefaultValueSql("1");

                entity.Property(e => e.Link).HasMaxLength(500);

                entity.Property(e => e.ObjectRefName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ObjectType).HasMaxLength(200);
            });

            modelBuilder.Entity<Oe>(entity =>
            {
                entity.HasKey(e => e.Oecode)
                    .HasName("PK_OE");

                entity.ToTable("OE");

                entity.Property(e => e.Oecode)
                    .HasColumnName("OECode")
                    .HasMaxLength(6);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Oename)
                    .IsRequired()
                    .HasColumnName("OEName")
                    .HasMaxLength(100);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.Oe)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_OE_Country");
            });

            modelBuilder.Entity<OfflinePos>(entity =>
            {
                entity.HasKey(e => new { e.OfflinePoscode, e.OnlinePoscode })
                    .HasName("PK_OfflinePOS");

                entity.ToTable("OfflinePOS");

                entity.Property(e => e.OfflinePoscode)
                    .HasColumnName("OfflinePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.OnlinePoscode)
                    .HasColumnName("OnlinePOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.OfflinePoscodeNavigation)
                    .WithMany(p => p.OfflinePosOfflinePoscodeNavigation)
                    .HasForeignKey(d => d.OfflinePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfflinePOS_POS1");

                entity.HasOne(d => d.OnlinePoscodeNavigation)
                    .WithMany(p => p.OfflinePosOnlinePoscodeNavigation)
                    .HasForeignKey(d => d.OnlinePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_OfflinePOS_POS");
            });

            modelBuilder.Entity<OnlineBatch>(entity =>
            {
                entity.HasKey(e => new { e.BatchCode, e.CustomerCode, e.OrderCode })
                    .HasName("PK_OnlineBatch");

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.HasOne(d => d.OnlineOrder)
                    .WithMany(p => p.OnlineBatch)
                    .HasForeignKey(d => new { d.OrderCode, d.CustomerCode })
                    .HasConstraintName("FK_OnlineBatch_OnlineOrder");
            });

            modelBuilder.Entity<OnlineItem>(entity =>
            {
                entity.HasKey(e => e.ItemIndex)
                    .HasName("PK_OnlineItem");

                entity.Property(e => e.ItemIndex).ValueGeneratedNever();

                entity.Property(e => e.AddressCode).HasMaxLength(6);

                entity.Property(e => e.BatchCode).HasMaxLength(13);

                entity.Property(e => e.Bc16index).HasColumnName("BC16Index");

                entity.Property(e => e.CertificateNumber).HasMaxLength(50);

                entity.Property(e => e.CheckSum).HasMaxLength(1);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.DataCode).HasMaxLength(50);

                entity.Property(e => e.DistrictCode).HasMaxLength(4);

                entity.Property(e => e.EmployeeCode).HasMaxLength(50);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ItemNumber).HasMaxLength(50);

                entity.Property(e => e.ItemTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LicenseNumber).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.Poscode)
                    .IsRequired()
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomReference).HasMaxLength(500);

                entity.Property(e => e.ReceiverEmail).HasMaxLength(50);

                entity.Property(e => e.ReceiverFax).HasMaxLength(15);

                entity.Property(e => e.ReceiverFullname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverIdentification).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueCountry).HasMaxLength(50);

                entity.Property(e => e.ReceiverIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverJob).HasMaxLength(500);

                entity.Property(e => e.ReceiverMobile).HasMaxLength(15);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.SectionCode).HasMaxLength(3);

                entity.Property(e => e.SenderAddress).HasMaxLength(50);

                entity.Property(e => e.SenderCustomReference).HasMaxLength(500);

                entity.Property(e => e.SenderEmail).HasMaxLength(50);

                entity.Property(e => e.SenderFax).HasMaxLength(15);

                entity.Property(e => e.SenderFullname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SenderIdentification).HasMaxLength(50);

                entity.Property(e => e.SenderIssueCountry).HasMaxLength(50);

                entity.Property(e => e.SenderIssueDate).HasColumnType("datetime");

                entity.Property(e => e.SenderJob).HasMaxLength(500);

                entity.Property(e => e.SenderMobile).HasMaxLength(15);

                entity.Property(e => e.SenderTel).HasMaxLength(15);

                entity.Property(e => e.SendingContent)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Vatfreight).HasColumnName("VATFreight");
            });

            modelBuilder.Entity<OnlineOrder>(entity =>
            {
                entity.HasKey(e => new { e.OrderCode, e.CustomerCode })
                    .HasName("PK_OnlineOrder");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Poscode)
                    .IsRequired()
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.OnlineOrder)
                    .HasForeignKey(d => d.CustomerCode)
                    .HasConstraintName("FK_OnlineOrder_Customer");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => new { e.OrderCode, e.Poscode, e.CustomerCode })
                    .HasName("PK_Order");

                entity.Property(e => e.OrderCode).HasMaxLength(5);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.Content).HasMaxLength(500);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Order_Customer");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => new { e.InvoiceNumber, e.CustomerCode, e.Poscode })
                    .HasName("PK_Payment");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.InputUser).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CustomerCode)
                    .HasConstraintName("FK_Payment_Customer1");
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.PermissionId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PermissionAndGroupPermission>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK_PermissionAndGroupPermission");

                entity.Property(e => e.PerId).ValueGeneratedNever();

                entity.HasOne(d => d.PermissionGroup)
                    .WithMany(p => p.PermissionAndGroupPermission)
                    .HasForeignKey(d => d.PermissionGroupId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PermissionAndGroupPermission_PermissionGroup");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionAndGroupPermission)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PermissionAndGroupPermission_Permission");
            });

            modelBuilder.Entity<PermissionGroup>(entity =>
            {
                entity.Property(e => e.PermissionGroupId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PermissionGroupName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PermissionGroupReportShiftReport>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.GroupCode })
                    .HasName("PK_Permission_GroupReport_ShiftReport");

                entity.ToTable("Permission_GroupReport_ShiftReport");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.GroupCode).HasMaxLength(10);
            });

            modelBuilder.Entity<PermissionReportShiftReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_Permission_ShiftReport");

                entity.ToTable("Permission_Report_ShiftReport");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.ReportDes).HasMaxLength(200);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<PetrolFreightSurchargeRule>(entity =>
            {
                entity.HasKey(e => new { e.PetrolFreightSurchargeRuleCode, e.ServiceCode })
                    .HasName("PK_PetrolFreightSurchargeRule_1");

                entity.Property(e => e.PetrolFreightSurchargeRuleCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNo).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Phase>(entity =>
            {
                entity.HasKey(e => e.PhaseCode)
                    .HasName("PK_Phase");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ParentPhaseCode).HasMaxLength(3);

                entity.Property(e => e.PhaseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ParentPhaseCodeNavigation)
                    .WithMany(p => p.InverseParentPhaseCodeNavigation)
                    .HasForeignKey(d => d.ParentPhaseCode)
                    .HasConstraintName("FK_Phase_Phase");
            });

            modelBuilder.Entity<PhaseQualityTarget>(entity =>
            {
                entity.HasKey(e => new { e.PhaseCode, e.ServiceCode, e.RegionTypeCode, e.QualityTargetRuleCode })
                    .HasName("PK_PhaseQualityTarget");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RegionTypeCode).HasMaxLength(1);

                entity.Property(e => e.QualityTargetRuleCode).HasMaxLength(5);

                entity.HasOne(d => d.RegionTypeCodeNavigation)
                    .WithMany(p => p.PhaseQualityTarget)
                    .HasForeignKey(d => d.RegionTypeCode)
                    .HasConstraintName("FK_PhaseQualityTarget_RegionType");

                entity.HasOne(d => d.ServicePhase)
                    .WithMany(p => p.PhaseQualityTarget)
                    .HasForeignKey(d => new { d.PhaseCode, d.ServiceCode })
                    .HasConstraintName("FK_PhaseQualityTarget_ServicePhase");

                entity.HasOne(d => d.QualityTargetRule)
                    .WithMany(p => p.PhaseQualityTarget)
                    .HasForeignKey(d => new { d.QualityTargetRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_PhaseQualityTarget_QualityTargetRule");
            });

            modelBuilder.Entity<Pos>(entity =>
            {
                entity.HasKey(e => e.Poscode)
                    .HasName("PK_POS");

                entity.ToTable("POS");

                entity.HasIndex(e => new { e.Posname, e.Poscode })
                    .HasName("_dta_index_POS_6_1854629650__K1_2");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AddressCode).HasMaxLength(50);

                entity.Property(e => e.CommuneCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.DatabasePassword).HasMaxLength(255);

                entity.Property(e => e.DatabaseServer).HasMaxLength(50);

                entity.Property(e => e.DatabaseUsername).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PoslevelCode)
                    .IsRequired()
                    .HasColumnName("POSLevelCode")
                    .HasMaxLength(3);

                entity.Property(e => e.Posname)
                    .IsRequired()
                    .HasColumnName("POSName")
                    .HasMaxLength(100);

                entity.Property(e => e.PostypeCode)
                    .IsRequired()
                    .HasColumnName("POSTypeCode")
                    .HasMaxLength(2);

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.ServiceServer).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UnitCode).HasMaxLength(6);

                entity.HasOne(d => d.PoslevelCodeNavigation)
                    .WithMany(p => p.Pos)
                    .HasForeignKey(d => d.PoslevelCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POS_POSLevel");

                entity.HasOne(d => d.PostypeCodeNavigation)
                    .WithMany(p => p.Pos)
                    .HasForeignKey(d => d.PostypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POS_POSType");

                entity.HasOne(d => d.UnitCodeNavigation)
                    .WithMany(p => p.Pos)
                    .HasForeignKey(d => d.UnitCode)
                    .HasConstraintName("FK_POS_Unit");
            });

            modelBuilder.Entity<Posconfiguration>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.ConfigCode })
                    .HasName("PK_POSConfiguration");

                entity.ToTable("POSConfiguration");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ConfigCode).HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasMaxLength(50);

                entity.HasOne(d => d.ConfigCodeNavigation)
                    .WithMany(p => p.Posconfiguration)
                    .HasForeignKey(d => d.ConfigCode)
                    .HasConstraintName("FK_POSConfiguration_Configuration");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Posconfiguration)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_POSConfiguration_POS");
            });

            modelBuilder.Entity<PosfreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.Poscode, e.DomesticFreightRuleCode })
                    .HasName("PK_POSFreightRegion_1");

                entity.ToTable("POSFreightRegion");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.PosfreightRegion)
                    .HasForeignKey(d => d.Poscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POSFreightRegion_POS");

                entity.HasOne(d => d.FreightRegion)
                    .WithMany(p => p.PosfreightRegion)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POSFreightRegion_FreightRegion");
            });

            modelBuilder.Entity<Poslevel>(entity =>
            {
                entity.HasKey(e => e.PoslevelCode)
                    .HasName("PK_POSLevel");

                entity.ToTable("POSLevel");

                entity.Property(e => e.PoslevelCode)
                    .HasColumnName("POSLevelCode")
                    .HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PoslevelName)
                    .IsRequired()
                    .HasColumnName("POSLevelName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PosprintConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.PrintedMatterCode, e.ObjectName, e.Poscode })
                    .HasName("PK_POSPrintConfiguration");

                entity.ToTable("POSPrintConfiguration");

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.Property(e => e.ObjectName).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.PosprintConfiguration)
                    .HasForeignKey(d => d.Poscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POSPrintConfiguration_POS");

                entity.HasOne(d => d.PrintConfiguration)
                    .WithMany(p => p.PosprintConfiguration)
                    .HasForeignKey(d => new { d.PrintedMatterCode, d.ObjectName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_POSPrintConfiguration_PrintConfiguration");
            });

            modelBuilder.Entity<Posservice>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.ServiceCode })
                    .HasName("PK_POSService");

                entity.ToTable("POSService");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Posservice)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_POSService_POS");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.Posservice)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_POSService_Service");
            });

            modelBuilder.Entity<PostBag>(entity =>
            {
                entity.HasKey(e => new { e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber })
                    .HasName("PK_PostBag_1");

                entity.HasIndex(e => e.PackagingTime)
                    .HasName("IX_PostBag_PackingTime");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_PostBag_Status");

                entity.HasIndex(e => new { e.Weight, e.MailTripNumber, e.Year, e.ServiceCode, e.MailTripType, e.FromPoscode, e.ToPoscode, e.PostBagNumber })
                    .HasName("_dta_index_PostBag_11_478624748__K9_K8_K7_K6_K4_K5_K10_11");

                entity.HasIndex(e => new { e.Weight, e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber })
                    .HasName("_dta_index_PostBag_6_478624748__K1_K4_K5_K6_K7_K8_K9_11");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IncomingDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OpeningMachine).HasMaxLength(50);

                entity.Property(e => e.OpeningTime).HasColumnType("datetime");

                entity.Property(e => e.OpeningUser).HasMaxLength(50);

                entity.Property(e => e.PackagingMachine).HasMaxLength(50);

                entity.Property(e => e.PackagingTime).HasColumnType("datetime");

                entity.Property(e => e.PackagingUser).HasMaxLength(50);

                entity.Property(e => e.PostBagCode).HasMaxLength(50);

                entity.Property(e => e.PostBagNumber).HasMaxLength(3);

                entity.Property(e => e.PostBagTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.PostBagTypeCodeNavigation)
                    .WithMany(p => p.PostBag)
                    .HasForeignKey(d => d.PostBagTypeCode)
                    .HasConstraintName("FK_PostBag_PostBagType");

                entity.HasOne(d => d.Mailtrip)
                    .WithMany(p => p.PostBag)
                    .HasForeignKey(d => new { d.FromPoscode, d.ToPoscode, d.MailTripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_PostBag_Mailtrip");
            });

            modelBuilder.Entity<PostBagLog>(entity =>
            {
                entity.HasKey(e => e.PostBagLogCode)
                    .HasName("PK_PostBagLog");

                entity.Property(e => e.PostBagLogCode).HasMaxLength(12);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedUser).HasMaxLength(50);

                entity.Property(e => e.FromPoscode)
                    .IsRequired()
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.IncomingDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.LogContent).HasMaxLength(500);

                entity.Property(e => e.MailTripNumber)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.MailTripType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.OpeningMachine).HasMaxLength(50);

                entity.Property(e => e.OpeningTime).HasColumnType("datetime");

                entity.Property(e => e.OpeningUser).HasMaxLength(50);

                entity.Property(e => e.PackagingMachine).HasMaxLength(50);

                entity.Property(e => e.PackagingTime).HasColumnType("datetime");

                entity.Property(e => e.PackagingUser).HasMaxLength(50);

                entity.Property(e => e.PostBagCode).HasMaxLength(50);

                entity.Property(e => e.PostBagNumber).HasMaxLength(3);

                entity.Property(e => e.PostBagTypeCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ToPoscode)
                    .IsRequired()
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<PostBagType>(entity =>
            {
                entity.HasKey(e => e.PostBagTypeCode)
                    .HasName("PK_PostBagType");

                entity.Property(e => e.PostBagTypeCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PostBagTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.PostBagType)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_PostBagType_Service");
            });

            modelBuilder.Entity<PostmanDeliveryRoute>(entity =>
            {
                entity.HasKey(e => new { e.DelieveryRouteCode, e.FromPoscode, e.PostmanCode })
                    .HasName("PK_PostmanDeliveryRoute");

                entity.Property(e => e.DelieveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PostmanCode).HasMaxLength(50);

                entity.HasOne(d => d.DeliveryRoute)
                    .WithMany(p => p.PostmanDeliveryRoute)
                    .HasForeignKey(d => new { d.DelieveryRouteCode, d.FromPoscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostmanDeliveryRoute_DeliveryRoute");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PostmanDeliveryRoute)
                    .HasForeignKey(d => new { d.PostmanCode, d.FromPoscode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PostmanDeliveryRoute_User");
            });

            modelBuilder.Entity<Postype>(entity =>
            {
                entity.HasKey(e => e.PostypeCode)
                    .HasName("PK_POSType");

                entity.ToTable("POSType");

                entity.Property(e => e.PostypeCode)
                    .HasColumnName("POSTypeCode")
                    .HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PostypeName)
                    .IsRequired()
                    .HasColumnName("POSTypeName")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Posversion>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.MachineName })
                    .HasName("PK_POSVersion_1");

                entity.ToTable("POSVersion");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MachineName).HasMaxLength(150);

                entity.Property(e => e.Bccpdbversion)
                    .HasColumnName("BCCPDBVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.Bccpversion)
                    .IsRequired()
                    .HasColumnName("BCCPVersion")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WindowsVersion).HasMaxLength(150);
            });

            modelBuilder.Entity<PrintConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.PrintedMatterCode, e.ObjectName })
                    .HasName("PK_PrintConfiguration");

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.Property(e => e.ObjectName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.HasOne(d => d.PrintedMatterCodeNavigation)
                    .WithMany(p => p.PrintConfiguration)
                    .HasForeignKey(d => d.PrintedMatterCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_PrintConfiguration_PrintedMatter");
            });

            modelBuilder.Entity<PrintedMatter>(entity =>
            {
                entity.HasKey(e => e.PrintedMatterCode)
                    .HasName("PK_PrintedMatter");

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PrintedMatterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShortcutKey).HasMaxLength(1);
            });

            modelBuilder.Entity<PrintedMatterMachine>(entity =>
            {
                entity.HasKey(e => new { e.PrintedMatterCode, e.MachineCode, e.CounterCode, e.Poscode })
                    .HasName("PK_PrintedMatterMachine");

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.Property(e => e.MachineCode).HasMaxLength(3);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PrinterName).HasMaxLength(500);

                entity.HasOne(d => d.PrintedMatterCodeNavigation)
                    .WithMany(p => p.PrintedMatterMachine)
                    .HasForeignKey(d => d.PrintedMatterCode)
                    .HasConstraintName("FK_PrintedMatterMachine_PrintedMatter");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.PrintedMatterMachine)
                    .HasForeignKey(d => new { d.MachineCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_PrintedMatterMachine_Machine");
            });

            modelBuilder.Entity<PrintedMatterPhase>(entity =>
            {
                entity.HasKey(e => new { e.PrintedMatterCode, e.PhaseCode })
                    .HasName("PK_PrintedMatterPhase");

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.HasOne(d => d.PhaseCodeNavigation)
                    .WithMany(p => p.PrintedMatterPhase)
                    .HasForeignKey(d => d.PhaseCode)
                    .HasConstraintName("FK_PrintedMatterPhase_Phase");

                entity.HasOne(d => d.PrintedMatterCodeNavigation)
                    .WithMany(p => p.PrintedMatterPhase)
                    .HasForeignKey(d => d.PrintedMatterCode)
                    .HasConstraintName("FK_PrintedMatterPhase_PrintedMatter");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.PropertyCode)
                    .HasName("PK_Property");

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ControlValue).HasMaxLength(500);

                entity.Property(e => e.DataType).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.GroupPropertyCode).HasMaxLength(50);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.GroupPropertyCodeNavigation)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.GroupPropertyCode)
                    .HasConstraintName("FK_Property_GroupProperty");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode)
                    .HasName("PK_ProvinceCode");

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ProvinceListCode).HasMaxLength(100);

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RegionCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.RegionCodeNavigation)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.RegionCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Province_Region");
            });

            modelBuilder.Entity<ProvinceFreightRegion>(entity =>
            {
                entity.HasKey(e => new { e.FreightRegionCode, e.ServiceCode, e.ProvinceCode, e.DomesticFreightRuleCode })
                    .HasName("PK_ProvinceFreightRegion");

                entity.Property(e => e.FreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ProvinceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.ProvinceFreightRegion)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProvinceFreightRegion_Province");

                entity.HasOne(d => d.FreightRegion)
                    .WithMany(p => p.ProvinceFreightRegion)
                    .HasForeignKey(d => new { d.FreightRegionCode, d.ServiceCode, d.DomesticFreightRuleCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProvinceFreightRegion_FreightRegion");
            });

            modelBuilder.Entity<ProvinceInterconnect>(entity =>
            {
                entity.HasKey(e => new { e.FromProvinceCode, e.ToProvinceCode, e.DomesticFreightRuleCode, e.ServiceCode })
                    .HasName("PK_ProvinceInterconnect");

                entity.Property(e => e.FromProvinceCode).HasMaxLength(3);

                entity.Property(e => e.ToProvinceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.ProvinceInterconnect)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_ProvinceInterconnect_DomesticFreightRule");
            });

            modelBuilder.Entity<QualityTargetRule>(entity =>
            {
                entity.HasKey(e => new { e.QualityTargetRuleCode, e.ServiceCode })
                    .HasName("PK_QualityTargetRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_QualityTargetRule_ValueDate");

                entity.Property(e => e.QualityTargetRuleCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNo).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.QualityTargetRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_QualityTargetRule_Service");
            });

            modelBuilder.Entity<Range>(entity =>
            {
                entity.HasKey(e => e.RangeCode)
                    .HasName("PK_Range");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.RangeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RangeCause>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.CauseCode })
                    .HasName("PK_RangeCause");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.CauseCode).HasMaxLength(2);

                entity.HasOne(d => d.CauseCodeNavigation)
                    .WithMany(p => p.RangeCauseNavigation)
                    .HasForeignKey(d => d.CauseCode)
                    .HasConstraintName("FK_RangeCause_Cause");

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeCause)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeCause_Range");
            });

            modelBuilder.Entity<RangeCommodityType>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.CommodityTypeCode, e.ServiceCode })
                    .HasName("PK_RangeCommodityType");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeCommodityType)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeCommodityType_Range");

                entity.HasOne(d => d.ServiceCommodityType)
                    .WithMany(p => p.RangeCommodityType)
                    .HasForeignKey(d => new { d.ServiceCode, d.CommodityTypeCode })
                    .HasConstraintName("FK_RangeCommodityType_ServiceCommodityType");
            });

            modelBuilder.Entity<RangeServiceItemType>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.ServiceCode, e.ItemTypeCode })
                    .HasName("PK_RangeServiceItemType");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeServiceItemType)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeServiceItemType_Range");

                entity.HasOne(d => d.ServiceItemType)
                    .WithMany(p => p.RangeServiceItemType)
                    .HasForeignKey(d => new { d.ServiceCode, d.ItemTypeCode })
                    .HasConstraintName("FK_RangeServiceItemType_ServiceItemType");
            });

            modelBuilder.Entity<RangeSolution>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.SolutionCode })
                    .HasName("PK_RangeSolution");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.SolutionCode).HasMaxLength(2);

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeSolution)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeSolution_Range");

                entity.HasOne(d => d.SolutionCodeNavigation)
                    .WithMany(p => p.RangeSolution)
                    .HasForeignKey(d => d.SolutionCode)
                    .HasConstraintName("FK_RangeSolution_Solution");
            });

            modelBuilder.Entity<RangeUndeliveryGuide>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.UndeliveryGuideCode })
                    .HasName("PK_RangeUndeliveryGuide");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeUndeliveryGuide)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeUndeliveryGuide_Range");

                entity.HasOne(d => d.UndeliveryGuideCodeNavigation)
                    .WithMany(p => p.RangeUndeliveryGuide)
                    .HasForeignKey(d => d.UndeliveryGuideCode)
                    .HasConstraintName("FK_RangeUndeliveryGuide_UndeliveryGuide");
            });

            modelBuilder.Entity<RangeValueAddedServicePhase>(entity =>
            {
                entity.HasKey(e => new { e.RangeCode, e.ServiceCode, e.ValueAddedServiceCode, e.PhaseCode })
                    .HasName("PK_RangeValueAddedServicePhase");

                entity.Property(e => e.RangeCode).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.HasOne(d => d.RangeCodeNavigation)
                    .WithMany(p => p.RangeValueAddedServicePhase)
                    .HasForeignKey(d => d.RangeCode)
                    .HasConstraintName("FK_RangeValueAddedServicePhase_Range");

                entity.HasOne(d => d.ValueAddedServicePhase)
                    .WithMany(p => p.RangeValueAddedServicePhase)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode, d.PhaseCode })
                    .HasConstraintName("FK_RangeValueAddedServicePhase_RangeValueAddedServicePhase");
            });

            modelBuilder.Entity<ReceiverDomesticCompensate>(entity =>
            {
                entity.HasKey(e => new { e.ReceiverDomesticCompensateCode, e.DomesitcCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_ReceiverDomesticCompensate");

                entity.Property(e => e.ReceiverDomesticCompensateCode).HasMaxLength(10);

                entity.Property(e => e.DomesitcCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ClaimTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CompensateCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompensatePoscode)
                    .IsRequired()
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeciderName).HasMaxLength(50);

                entity.Property(e => e.InputDecideDate).HasColumnType("datetime");

                entity.Property(e => e.InputDeciderName).HasMaxLength(50);

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.ClaimTypeCodeNavigation)
                    .WithMany(p => p.ReceiverDomesticCompensate)
                    .HasForeignKey(d => d.ClaimTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverDomesticCompensate_ClaimType");

                entity.HasOne(d => d.CompensateCategoryCodeNavigation)
                    .WithMany(p => p.ReceiverDomesticCompensate)
                    .HasForeignKey(d => d.CompensateCategoryCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverDomesticCompensate_CompensateCategory");

                entity.HasOne(d => d.CompensatePoscodeNavigation)
                    .WithMany(p => p.ReceiverDomesticCompensate)
                    .HasForeignKey(d => d.CompensatePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverDomesticCompensate_POS");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ReceiverDomesticCompensate)
                    .HasForeignKey(d => new { d.ClaimNumber, d.RecevingClaimPoscode })
                    .HasConstraintName("FK_RDC_claimNum");

                entity.HasOne(d => d.DomesticCompensateRule)
                    .WithMany(p => p.ReceiverDomesticCompensate)
                    .HasForeignKey(d => new { d.DomesitcCompensateRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_ReceiverDomesticCompensate_DomesticCompensateRule");
            });

            modelBuilder.Entity<ReceiverInternationalCompensate>(entity =>
            {
                entity.HasKey(e => new { e.ReceiverInternationalCompensateCode, e.InternationalCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_ReceiverInternationalCompensate");

                entity.Property(e => e.ReceiverInternationalCompensateCode).HasMaxLength(10);

                entity.Property(e => e.InternationalCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ClaimTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CompensateCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompensatePoscode)
                    .IsRequired()
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeciderName).HasMaxLength(50);

                entity.Property(e => e.ExchangeCode).HasMaxLength(3);

                entity.Property(e => e.InputDecideDate).HasColumnType("datetime");

                entity.Property(e => e.InputDeciderName).HasMaxLength(50);

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.ClaimTypeCodeNavigation)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => d.ClaimTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverInternationalCompensate_ClaimType");

                entity.HasOne(d => d.CompensateCategoryCodeNavigation)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => d.CompensateCategoryCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverInternationalCompensate_CompensateCategory");

                entity.HasOne(d => d.CompensatePoscodeNavigation)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => d.CompensatePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReceiverInternationalCompensate_POS");

                entity.HasOne(d => d.ExchangeCodeNavigation)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => d.ExchangeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ReceiverInternationalCompensate_Exchange");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => new { d.ClaimNumber, d.RecevingClaimPoscode })
                    .HasConstraintName("FK_RIC_claimNum");

                entity.HasOne(d => d.InternationalCompensateRule)
                    .WithMany(p => p.ReceiverInternationalCompensate)
                    .HasForeignKey(d => new { d.InternationalCompensateRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_ReceiverInternationalCompensate_InternationalCompensateRule");
            });

            modelBuilder.Entity<ReceiverReason>(entity =>
            {
                entity.HasKey(e => e.ReceiverReasonCode)
                    .HasName("PK_ReceiverReason");

                entity.Property(e => e.ReceiverReasonCode).ValueGeneratedNever();

                entity.Property(e => e.ReceiverReasonName).HasMaxLength(50);
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.RegionCode)
                    .HasName("PK_Region");

                entity.Property(e => e.RegionCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RegionInterconnect>(entity =>
            {
                entity.HasKey(e => new { e.FromFreightRegionCode, e.ToFreightRegionCode, e.DomesticFreightRuleCode, e.ServiceCode })
                    .HasName("PK_RegionInterconnect");

                entity.Property(e => e.FromFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.ToFreightRegionCode).HasMaxLength(2);

                entity.Property(e => e.DomesticFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.DomesticFreightRule)
                    .WithMany(p => p.RegionInterconnect)
                    .HasForeignKey(d => new { d.DomesticFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_RegionInterconnect_DomesticFreightRule");
            });

            modelBuilder.Entity<RegionType>(entity =>
            {
                entity.HasKey(e => e.RegionTypeCode)
                    .HasName("PK_RegionType");

                entity.Property(e => e.RegionTypeCode).HasMaxLength(1);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RegionTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RevenueSharing>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ItemCode, e.Poscode, e.PhaseCode })
                    .HasName("PK_RevenueSharing");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.RevenueSharing)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_RevenueSharing_Item");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.RevenueSharing)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_RevenueSharing_POS");

                entity.HasOne(d => d.ServicePhase)
                    .WithMany(p => p.RevenueSharing)
                    .HasForeignKey(d => new { d.PhaseCode, d.ServiceCode })
                    .HasConstraintName("FK_RevenueSharing_ServicePhase");
            });

            modelBuilder.Entity<RevenueSharingItemType>(entity =>
            {
                entity.HasKey(e => new { e.ProvinceCode, e.ValueDate, e.ItemType, e.ServiceCode })
                    .HasName("PK_RevenueSharingItemType");

                entity.Property(e => e.ProvinceCode).HasMaxLength(2);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.ItemType).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(6);
            });

            modelBuilder.Entity<RevenueSharingRule>(entity =>
            {
                entity.HasKey(e => new { e.RevenueSharingRuleCode, e.ServiceCode })
                    .HasName("PK_RevenueSharingRule");

                entity.HasIndex(e => e.ValueDate)
                    .HasName("IX_RevenueSharingRule_ValueDate");

                entity.Property(e => e.RevenueSharingRuleCode).HasMaxLength(5);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.RuleNumber).HasMaxLength(50);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.RevenueSharingRule)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_RevenueSharingRule_Service");
            });

            modelBuilder.Entity<RevenueSharingValueAddedService>(entity =>
            {
                entity.HasKey(e => new { e.ProvinceCode, e.ValueDate, e.ValueAddedService, e.ServiceCode })
                    .HasName("PK_RevenueSharingValueAddedService");

                entity.Property(e => e.ProvinceCode).HasMaxLength(2);

                entity.Property(e => e.ValueDate).HasColumnType("datetime");

                entity.Property(e => e.ValueAddedService).HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(6);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleCode)
                    .HasName("PK_Role");

                entity.Property(e => e.RoleCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ParentRoleCode).HasMaxLength(50);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.ParentRoleCodeNavigation)
                    .WithMany(p => p.InverseParentRoleCodeNavigation)
                    .HasForeignKey(d => d.ParentRoleCode)
                    .HasConstraintName("FK_Role_Role");
            });

            modelBuilder.Entity<RoleObject>(entity =>
            {
                entity.Property(e => e.RoleObjectId).ValueGeneratedNever();

                entity.HasOne(d => d.ObjectRef)
                    .WithMany(p => p.RoleObject)
                    .HasForeignKey(d => d.ObjectRefId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleObject_ObjectRef");

                entity.HasOne(d => d.RolesGrantPermission)
                    .WithMany(p => p.RoleObject)
                    .HasForeignKey(d => d.RolesGrantPermissionId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RoleObject_RolesGrantPermission");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasKey(e => new { e.RoleObjectId, e.GroupCode })
                    .HasName("PK_RolePermission");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.GroupCode)
                    .HasConstraintName("FK_RolePermission_Group");

                entity.HasOne(d => d.RoleObject)
                    .WithMany(p => p.RolePermission)
                    .HasForeignKey(d => d.RoleObjectId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RolePermission_RoleObject");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleCode)
                    .HasName("PK_Roles");

                entity.Property(e => e.RoleCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RolesGrantPermission>(entity =>
            {
                entity.Property(e => e.RolesGrantPermissionId).ValueGeneratedNever();

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Per)
                    .WithMany(p => p.RolesGrantPermission)
                    .HasForeignKey(d => d.PerId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RolesGrantPermission_PermissionAndGroupPermission");

                entity.HasOne(d => d.RoleCodeNavigation)
                    .WithMany(p => p.RolesGrantPermission)
                    .HasForeignKey(d => d.RoleCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RolesGrantPermission_Roles");
            });

            modelBuilder.Entity<RpAcceptanceDetailReport>(entity =>
            {
                entity.HasKey(e => new { e.TargetIndex, e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.ItemCode })
                    .HasName("PK_RP_AcceptanceDetailReport");

                entity.ToTable("RP_AcceptanceDetailReport");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AcceptancePoscode)
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AcceptanceUser).HasMaxLength(50);

                entity.Property(e => e.ContractNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuocGtgt).HasColumnName("CuocGTGT");

                entity.Property(e => e.CuocGtgtcongBo).HasColumnName("CuocGTGTCongBo");

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.Property(e => e.DonViPhat).HasMaxLength(6);

                entity.Property(e => e.GiaVonCuocGtgt).HasColumnName("GiaVonCuocGTGT");

                entity.Property(e => e.IsCod).HasColumnName("IsCOD");

                entity.Property(e => e.IsDomestic).HasColumnName("isDomestic");

                entity.Property(e => e.IsHcc).HasColumnName("isHCC");

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.ValueAddedServicesCode).HasMaxLength(50);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpAcceptanceDetailReport)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RP_AcceptanceDetailReport_RP_ReportTargets");
            });

            modelBuilder.Entity<RpAcceptanceReports>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.TargetIndex })
                    .HasName("PK_AcceptanceReports");

                entity.ToTable("RP_AcceptanceReports");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuocGtgt).HasColumnName("CuocGTGT");

                entity.Property(e => e.CuocVat).HasColumnName("CuocVAT");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SauckCovat).HasColumnName("SAUCK_COVAT");

                entity.Property(e => e.SauckKhongvat).HasColumnName("SAUCK_KHONGVAT");

                entity.Property(e => e.TruocckCovat).HasColumnName("TRUOCCK_COVAT");

                entity.Property(e => e.TruocckKhongvat).HasColumnName("TRUOCCK_KHONGVAT");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Vatno).HasColumnName("VATNo");

                entity.Property(e => e.VattienMat).HasColumnName("VATTienMat");

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpAcceptanceReports)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcceptanceReports_ReportTargets");
            });

            modelBuilder.Entity<RpAcceptanceReportsForOther>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.TargetIndex, e.AcceptancePoscode, e.Status })
                    .HasName("PK_RP_AcceptanceReportsForOther");

                entity.ToTable("RP_AcceptanceReportsForOther");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.AcceptancePoscode)
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuocGtgt).HasColumnName("CuocGTGT");

                entity.Property(e => e.CuocVat).HasColumnName("CuocVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Vatno).HasColumnName("VATNo");

                entity.Property(e => e.VattienMat).HasColumnName("VATTienMat");

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpAcceptanceReportsForOther)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_AcceptanceReportsForOther_ReportTargets");
            });

            modelBuilder.Entity<RpCustomerAcceptanceReports>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.CustomerCode, e.TargetIndex })
                    .HasName("PK_RP_CustomerAcceptanceReports");

                entity.ToTable("RP_CustomerAcceptanceReports");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CustomerCode).HasMaxLength(30);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuocGtgt).HasColumnName("CuocGTGT");

                entity.Property(e => e.CuocVat).HasColumnName("CuocVAT");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SauckCovat).HasColumnName("SAUCK_COVAT");

                entity.Property(e => e.SauckKhongvat).HasColumnName("SAUCK_KHONGVAT");

                entity.Property(e => e.TruocckCovat).HasColumnName("TRUOCCK_COVAT");

                entity.Property(e => e.TruocckKhongvat).HasColumnName("TRUOCCK_KHONGVAT");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Vatno).HasColumnName("VATNo");

                entity.Property(e => e.VattienMat).HasColumnName("VATTienMat");

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpCustomerAcceptanceReports)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .HasConstraintName("FK_RP_CustomerAcceptanceReports_RP_ReportTargets");
            });

            modelBuilder.Entity<RpCustomerAcceptanceReportsForOther>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.CustomerCode, e.TargetIndex, e.AcceptancePoscode, e.Status })
                    .HasName("PK_RP_CustomerAcceptanceReportsForOther");

                entity.ToTable("RP_CustomerAcceptanceReportsForOther");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CustomerCode).HasMaxLength(30);

                entity.Property(e => e.AcceptancePoscode)
                    .HasColumnName("AcceptancePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CuocGtgt).HasColumnName("CuocGTGT");

                entity.Property(e => e.CuocVat).HasColumnName("CuocVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SauckCovat).HasColumnName("SAUCK_COVAT");

                entity.Property(e => e.SauckKhongvat).HasColumnName("SAUCK_KHONGVAT");

                entity.Property(e => e.TruocckCovat).HasColumnName("TRUOCCK_COVAT");

                entity.Property(e => e.TruocckKhongvat).HasColumnName("TRUOCCK_KHONGVAT");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Vatno).HasColumnName("VATNo");

                entity.Property(e => e.VattienMat).HasColumnName("VATTienMat");

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpCustomerAcceptanceReportsForOther)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .HasConstraintName("FK_RP_CustomerAcceptanceReportsForOther_RP_ReportTargets");
            });

            modelBuilder.Entity<RpDeliveryReports>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.TargetIndex })
                    .HasName("PK_RP_DeliveryReports");

                entity.ToTable("RP_DeliveryReports");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaBuuTa).HasMaxLength(15);

                entity.Property(e => e.MaTuyenPhat).HasMaxLength(15);

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpDeliveryReports)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_DeliveryReports_ReportTargets");
            });

            modelBuilder.Entity<RpObjectParameters>(entity =>
            {
                entity.HasKey(e => new { e.StoreProcedureName, e.ParameterName })
                    .HasName("PK_ObjectParameters");

                entity.ToTable("RP_ObjectParameters");

                entity.Property(e => e.StoreProcedureName).HasMaxLength(150);

                entity.Property(e => e.ParameterName).HasMaxLength(50);

                entity.Property(e => e.ParameterValue).HasMaxLength(50);

                entity.HasOne(d => d.StoreProcedureNameNavigation)
                    .WithMany(p => p.RpObjectParameters)
                    .HasForeignKey(d => d.StoreProcedureName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ObjectParameters_ObjectsFillReportsData");
            });

            modelBuilder.Entity<RpObjectsFillReportsData>(entity =>
            {
                entity.HasKey(e => e.StoreProcedureName)
                    .HasName("PK_ObjectsFillReportsData_1");

                entity.ToTable("RP_ObjectsFillReportsData");

                entity.Property(e => e.StoreProcedureName).HasMaxLength(150);
            });

            modelBuilder.Entity<RpProcessingReports>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.TargetIndex })
                    .HasName("PK_ProcessingReports");

                entity.ToTable("RP_ProcessingReports");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpProcessingReports)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_MailtripReports_ReportTargets");
            });

            modelBuilder.Entity<RpReportTargetCatalog>(entity =>
            {
                entity.HasKey(e => e.ReportTargetCatalogCode)
                    .HasName("PK_ReportTargetCatalog");

                entity.ToTable("RP_ReportTargetCatalog");

                entity.Property(e => e.ReportTargetCatalogCode).HasMaxLength(15);

                entity.Property(e => e.ParentTargetCatalogCode).HasMaxLength(15);

                entity.Property(e => e.ReportTargetCatalogName).HasMaxLength(200);

                entity.HasOne(d => d.ParentTargetCatalogCodeNavigation)
                    .WithMany(p => p.InverseParentTargetCatalogCodeNavigation)
                    .HasForeignKey(d => d.ParentTargetCatalogCode)
                    .HasConstraintName("FK_RP_ReportTargetCatalog_RP_ReportTargetCatalog");
            });

            modelBuilder.Entity<RpReportTargetProperties>(entity =>
            {
                entity.HasKey(e => new { e.ReportTargetCode, e.ReportTargetPropertyCode })
                    .HasName("PK_ReportTargetProperties");

                entity.ToTable("RP_ReportTargetProperties");

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.ReportTargetPropertyCode).HasMaxLength(15);

                entity.Property(e => e.ReportTargetPropertyName).HasMaxLength(200);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpReportTargetProperties)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportTargetProperties_ReportTargets");
            });

            modelBuilder.Entity<RpReportTargetPropertyValues>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.ReportTargetPropertyCode })
                    .HasName("PK_ReportTargetPropertyValues");

                entity.ToTable("RP_ReportTargetPropertyValues");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.ReportTargetPropertyCode).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.ReportTarget)
                    .WithMany(p => p.RpReportTargetPropertyValues)
                    .HasForeignKey(d => new { d.ReportTargetCode, d.ReportTargetPropertyCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportTargetPropertyValues_ReportTargetProperties");
            });

            modelBuilder.Entity<RpReportTargets>(entity =>
            {
                entity.HasKey(e => e.ReportTargetCode)
                    .HasName("PK_ReportTargets");

                entity.ToTable("RP_ReportTargets");

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.ReportTargetCatalogCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ReportTargetName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.StoreProcedureName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.ReportTargetCatalogCodeNavigation)
                    .WithMany(p => p.RpReportTargets)
                    .HasForeignKey(d => d.ReportTargetCatalogCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportTargets_ReportTargetCatalog");

                entity.HasOne(d => d.StoreProcedureNameNavigation)
                    .WithMany(p => p.RpReportTargets)
                    .HasForeignKey(d => d.StoreProcedureName)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ReportTargets_ObjectsFillReportsData");
            });

            modelBuilder.Entity<RpTargetValueChanges>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.ChangedIndex })
                    .HasName("PK_TargetValueChange");

                entity.ToTable("RP_TargetValueChanges");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ChangedUser)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpTargetValueChanges)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_RP_TargetValueChanges_RP_ReportTargets");
            });

            modelBuilder.Entity<RpTransportReports>(entity =>
            {
                entity.HasKey(e => new { e.InsertedDate, e.Poscode, e.ShiftCode, e.ReportTargetCode, e.TargetIndex })
                    .HasName("PK_RP_TransportReports");

                entity.ToTable("RP_TransportReports");

                entity.Property(e => e.InsertedDate).HasMaxLength(8);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(6);

                entity.Property(e => e.ReportTargetCode).HasMaxLength(15);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.HasOne(d => d.ReportTargetCodeNavigation)
                    .WithMany(p => p.RpTransportReports)
                    .HasForeignKey(d => d.ReportTargetCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TransportReports_ReportTargets");
            });

            modelBuilder.Entity<SaleChannel>(entity =>
            {
                entity.HasKey(e => e.SaleChannelCode)
                    .HasName("PK_SaleChannel");

                entity.Property(e => e.SaleChannelCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.SaleChannelName).HasMaxLength(50);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => new { e.SectionCode, e.Poscode })
                    .HasName("PK_Section");

                entity.Property(e => e.SectionCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.SectionName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Section)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_Section_POS");
            });

            modelBuilder.Entity<SenderDomesticCompensate>(entity =>
            {
                entity.HasKey(e => new { e.SenderDomesticCompensateCode, e.DomesitcCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_SenderDomesticCompensate");

                entity.Property(e => e.SenderDomesticCompensateCode).HasMaxLength(10);

                entity.Property(e => e.DomesitcCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ClaimTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CompensateCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompensatePoscode)
                    .IsRequired()
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeciderName).HasMaxLength(50);

                entity.Property(e => e.InputDecideDate).HasColumnType("datetime");

                entity.Property(e => e.InputDeciderName).HasMaxLength(50);

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.ClaimTypeCodeNavigation)
                    .WithMany(p => p.SenderDomesticCompensate)
                    .HasForeignKey(d => d.ClaimTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SenderDomesticCompensate_ClaimType");

                entity.HasOne(d => d.CompensateCategoryCodeNavigation)
                    .WithMany(p => p.SenderDomesticCompensate)
                    .HasForeignKey(d => d.CompensateCategoryCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SenderDomesticCompensate_CompensateCategory");

                entity.HasOne(d => d.CompensatePoscodeNavigation)
                    .WithMany(p => p.SenderDomesticCompensate)
                    .HasForeignKey(d => d.CompensatePoscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SenderDomesticCompensate_POS");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.SenderDomesticCompensate)
                    .HasForeignKey(d => new { d.ClaimNumber, d.RecevingClaimPoscode })
                    .HasConstraintName("FK_SDC_claimNum");

                entity.HasOne(d => d.DomesticCompensateRule)
                    .WithMany(p => p.SenderDomesticCompensate)
                    .HasForeignKey(d => new { d.DomesitcCompensateRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_SenderDomesticCompensate_DomesticCompensateRule");
            });

            modelBuilder.Entity<SenderInternationalCompensate>(entity =>
            {
                entity.HasKey(e => new { e.SenderInternationalCompensateCode, e.InternationalCompensateRuleCode, e.ServiceCode })
                    .HasName("PK_SenderInternationalCompensate");

                entity.Property(e => e.SenderInternationalCompensateCode).HasMaxLength(10);

                entity.Property(e => e.InternationalCompensateRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ClaimTypeCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CompensateCategoryCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CompensatePoscode)
                    .IsRequired()
                    .HasColumnName("CompensatePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.DeciderName).HasMaxLength(50);

                entity.Property(e => e.ExchangeCode).HasMaxLength(3);

                entity.Property(e => e.InputDecideDate).HasColumnType("datetime");

                entity.Property(e => e.InputDeciderName).HasMaxLength(50);

                entity.Property(e => e.RecevingClaimPoscode)
                    .HasColumnName("RecevingClaimPOSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.ExchangeCodeNavigation)
                    .WithMany(p => p.SenderInternationalCompensate)
                    .HasForeignKey(d => d.ExchangeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SenderInternationalCompensate_Exchange");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.SenderInternationalCompensate)
                    .HasForeignKey(d => new { d.ClaimNumber, d.RecevingClaimPoscode })
                    .HasConstraintName("FK_claimNum");

                entity.HasOne(d => d.InternationalCompensateRule)
                    .WithMany(p => p.SenderInternationalCompensate)
                    .HasForeignKey(d => new { d.InternationalCompensateRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_SenderInternationalCompensate_InternationalCompensateRule");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.HasKey(e => new { e.ServerCode, e.Poscode })
                    .HasName("PK_Server");

                entity.Property(e => e.ServerCode).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Server)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_Server_POS");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ServiceCode)
                    .HasName("PK_Service");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.AutomaticGenerationCharacterFrom).HasMaxLength(1);

                entity.Property(e => e.AutomaticGenerationCharacterTo).HasMaxLength(1);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ImageName).HasMaxLength(500);

                entity.Property(e => e.PrintCharacterFrom).HasMaxLength(1);

                entity.Property(e => e.PrintCharacterTo).HasMaxLength(1);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServicePriorityCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ServiceTypeCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ShortName).HasMaxLength(10);

                entity.Property(e => e.ShortcutKey).HasMaxLength(1);

                entity.Property(e => e.SupplyScope).HasMaxLength(500);

                entity.Property(e => e.Vatpercentage).HasColumnName("VATPercentage");

                entity.HasOne(d => d.ServicePriorityCodeNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.ServicePriorityCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Service_ServicePriority");

                entity.HasOne(d => d.ServiceTypeCodeNavigation)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.ServiceTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Service_ServiceType");
            });

            modelBuilder.Entity<ServiceCommodityType>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.CommodityTypeCode })
                    .HasName("PK_ServiceCommodityType");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CommodityTypeCode).HasMaxLength(6);

                entity.HasOne(d => d.CommodityTypeCodeNavigation)
                    .WithMany(p => p.ServiceCommodityType)
                    .HasForeignKey(d => d.CommodityTypeCode)
                    .HasConstraintName("FK_ServiceCommodityType_CommodityType");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServiceCommodityType)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServiceCommodityType_ServiceCommodityType");
            });

            modelBuilder.Entity<ServiceConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ConfigCode })
                    .HasName("PK_ServiceConfiguration");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ConfigCode).HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasMaxLength(50);

                entity.HasOne(d => d.ConfigCodeNavigation)
                    .WithMany(p => p.ServiceConfiguration)
                    .HasForeignKey(d => d.ConfigCode)
                    .HasConstraintName("FK_ServiceConfiguration_Configuration");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServiceConfiguration)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServiceConfiguration_Service");
            });

            modelBuilder.Entity<ServiceItemRemaining>(entity =>
            {
                entity.HasKey(e => new { e.HandoverIndex, e.ShiftCode, e.Poscode, e.CounterCode, e.ServiceCode })
                    .HasName("PK_ServiceItemRemaining");

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(1);

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ServiceItemRemaining)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ServiceItemRemaining_ShiftHandover");
            });

            modelBuilder.Entity<ServiceItemType>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ItemTypeCode })
                    .HasName("PK_ServiceItemType");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.HasOne(d => d.ItemTypeCodeNavigation)
                    .WithMany(p => p.ServiceItemType)
                    .HasForeignKey(d => d.ItemTypeCode)
                    .HasConstraintName("FK_ServiceItemType_ItemType");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServiceItemType)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServiceItemType_Service");
            });

            modelBuilder.Entity<ServicePhase>(entity =>
            {
                entity.HasKey(e => new { e.PhaseCode, e.ServiceCode })
                    .HasName("PK_ServicePhase");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.HasOne(d => d.PhaseCodeNavigation)
                    .WithMany(p => p.ServicePhase)
                    .HasForeignKey(d => d.PhaseCode)
                    .HasConstraintName("FK_ServicePhase_Phase");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServicePhase)
                    .HasForeignKey(d => d.ServiceCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ServicePhase_Service");
            });

            modelBuilder.Entity<ServicePosconfiguration>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.ServiceCode, e.ConfigCode })
                    .HasName("PK_ServicePOSConfiguration");

                entity.ToTable("ServicePOSConfiguration");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ConfigCode).HasMaxLength(50);

                entity.Property(e => e.ConfigValue).HasMaxLength(50);

                entity.HasOne(d => d.ConfigCodeNavigation)
                    .WithMany(p => p.ServicePosconfiguration)
                    .HasForeignKey(d => d.ConfigCode)
                    .HasConstraintName("FK_ServicePOSConfiguration_Configuration");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.ServicePosconfiguration)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_ServicePOSConfiguration_POS");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServicePosconfiguration)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServicePOSConfiguration_Service");
            });

            modelBuilder.Entity<ServicePrintedMatter>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.PrintedMatterCode })
                    .HasName("PK_ServicePrintedMatter");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.PrintedMatterCode).HasMaxLength(5);

                entity.HasOne(d => d.PrintedMatterCodeNavigation)
                    .WithMany(p => p.ServicePrintedMatter)
                    .HasForeignKey(d => d.PrintedMatterCode)
                    .HasConstraintName("FK_ServicePrintedMatter_PrintedMatter");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServicePrintedMatter)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServicePrintedMatter_Service");
            });

            modelBuilder.Entity<ServicePriority>(entity =>
            {
                entity.HasKey(e => e.ServicePriorityCode)
                    .HasName("PK_ServicePriority");

                entity.Property(e => e.ServicePriorityCode).HasMaxLength(2);

                entity.Property(e => e.ServicePriorityName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ServiceProperty>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.PropertyCode })
                    .HasName("PK_ServiceProperty");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.HasOne(d => d.PropertyCodeNavigation)
                    .WithMany(p => p.ServiceProperty)
                    .HasForeignKey(d => d.PropertyCode)
                    .HasConstraintName("FK_ServiceProperty_Property");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServiceProperty)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServiceProperty_Service");
            });

            modelBuilder.Entity<ServiceSaleChannel>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.SaleChannelCode })
                    .HasName("PK_ServiceSaleChannel");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.SaleChannelCode).HasMaxLength(2);

                entity.HasOne(d => d.SaleChannelCodeNavigation)
                    .WithMany(p => p.ServiceSaleChannel)
                    .HasForeignKey(d => d.SaleChannelCode)
                    .HasConstraintName("FK_ServiceSaleChannel_SaleChannel");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.ServiceSaleChannel)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_ServiceSaleChannel_Service");
            });

            modelBuilder.Entity<ServiceSupplying>(entity =>
            {
                entity.HasKey(e => new { e.CommuneCode, e.Poscode })
                    .HasName("PK_ServiceSupplying");

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.ServiceSupplying)
                    .HasForeignKey(d => d.CommuneCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ServiceSupplying_Commune");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.ServiceSupplying)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_ServiceSupplying_POS");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.HasKey(e => e.ServiceTypeCode)
                    .HasName("PK_ServiceType");

                entity.Property(e => e.ServiceTypeCode).HasMaxLength(15);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ServiceTypeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ServiceTypeParentCode).HasMaxLength(15);

                entity.HasOne(d => d.ServiceTypeParentCodeNavigation)
                    .WithMany(p => p.InverseServiceTypeParentCodeNavigation)
                    .HasForeignKey(d => d.ServiceTypeParentCode)
                    .HasConstraintName("FK_ServiceType_ServiceType");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => new { e.ShiftCode, e.Poscode })
                    .HasName("PK_Shift");

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FinishHour).HasColumnType("datetime");

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.StartHour).HasColumnType("datetime");

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Shift)
                    .HasForeignKey(d => d.Poscode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Shift_POS");
            });

            modelBuilder.Entity<ShiftHandover>(entity =>
            {
                entity.HasKey(e => new { e.HandoverIndex, e.ShiftCode, e.CounterCode, e.Poscode })
                    .HasName("PK_ShiftHandover");

                entity.HasIndex(e => e.HandoverTime)
                    .HasName("IX_ShiftHandover_HandoverTime");

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.GivingUsername).HasMaxLength(50);

                entity.Property(e => e.HandoverTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OldDataItemClosingIn).HasColumnName("OldData_Item_Closing_IN");

                entity.Property(e => e.OldDataItemClosingOut).HasColumnName("OldData_Item_Closing_Out");

                entity.Property(e => e.OldDataItemOpened).HasColumnName("OldData_Item_Opened");

                entity.Property(e => e.OldDataItemOpenedC).HasColumnName("OldData_Item_Opened_C");

                entity.Property(e => e.OldDataItemOpenedE).HasColumnName("OldData_Item_Opened_E");

                entity.Property(e => e.OldDataItemOpenedK).HasColumnName("OldData_Item_Opened_K");

                entity.Property(e => e.OldDataItemOpenedR).HasColumnName("OldData_Item_Opened_R");

                entity.Property(e => e.OldDataItemOpenedT).HasColumnName("OldData_Item_Opened_T");

                entity.Property(e => e.OldDataItemOpenedU).HasColumnName("OldData_Item_Opened_U");

                entity.Property(e => e.OldDataItemWeightClosingIn).HasColumnName("OldData_ItemWeight_Closing_IN");

                entity.Property(e => e.OldDataItemWeightClosingOut).HasColumnName("OldData_ItemWeight_Closing_Out");

                entity.Property(e => e.OldDataItemWeightOpened).HasColumnName("OldData_ItemWeight_Opened");

                entity.Property(e => e.OldDataItemWeightOpenedC).HasColumnName("OldData_ItemWeight_Opened_C");

                entity.Property(e => e.OldDataItemWeightOpenedE).HasColumnName("OldData_ItemWeight_Opened_E");

                entity.Property(e => e.OldDataItemWeightOpenedK).HasColumnName("OldData_ItemWeight_Opened_K");

                entity.Property(e => e.OldDataItemWeightOpenedR).HasColumnName("OldData_ItemWeight_Opened_R");

                entity.Property(e => e.OldDataItemWeightOpenedT).HasColumnName("OldData_ItemWeight_Opened_T");

                entity.Property(e => e.OldDataItemWeightOpenedU).HasColumnName("OldData_ItemWeight_Opened_U");

                entity.Property(e => e.OldDataPostbagClosingIn).HasColumnName("OldData_Postbag_Closing_IN");

                entity.Property(e => e.OldDataPostbagOpened).HasColumnName("OldData_Postbag_Opened");

                entity.Property(e => e.OldDataPostbagWeightClosingIn).HasColumnName("OldData_PostbagWeight_Closing_IN");

                entity.Property(e => e.OldDataPostbagWeightOpened).HasColumnName("OldData_PostbagWeight_Opened");

                entity.Property(e => e.RecevingUsername).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.ShiftHandover)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_ShiftHandover_POS");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.ShiftHandover)
                    .HasForeignKey(d => new { d.ShiftCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandover_Shift1");
            });

            modelBuilder.Entity<ShiftHandoverBc37>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.HandoverIndex, e.ShiftCode, e.CounterCode, e.Bc37date, e.Bc37index, e.FromPoscode, e.ToPoscode, e.TransportTypeCode, e.Status })
                    .HasName("PK_ShiftHandoverBC37_1");

                entity.ToTable("ShiftHandoverBC37");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.Bc37date)
                    .HasColumnName("BC37Date")
                    .HasMaxLength(8);

                entity.Property(e => e.Bc37index).HasColumnName("BC37Index");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ShiftHandoverBc37)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandoverBC37_ShiftHandover");

                entity.HasOne(d => d.Bc37)
                    .WithMany(p => p.ShiftHandoverBc37)
                    .HasForeignKey(d => new { d.Bc37index, d.FromPoscode, d.ToPoscode, d.TransportTypeCode, d.Bc37date })
                    .HasConstraintName("FK_ShiftHandoverBC37_BC37");
            });

            modelBuilder.Entity<ShiftHandoverItem>(entity =>
            {
                entity.HasKey(e => new { e.HandoverIndex, e.ShiftCode, e.Poscode, e.ItemCode, e.CounterCode, e.Status })
                    .HasName("PK_ShiftHandoverItem");

                entity.HasIndex(e => new { e.ItemCode, e.HandoverIndex, e.Poscode, e.Status, e.ShiftCodeOlder })
                    .HasName("Item_Report_Offline02");

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftCodeOlder).HasMaxLength(10);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ShiftHandoverItem)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ShiftHandoverItem_Item");

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ShiftHandoverItem)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandoverItem_ShiftHandover");
            });

            modelBuilder.Entity<ShiftHandoverMailtrip>(entity =>
            {
                entity.HasKey(e => new { e.HandoverIndex, e.CounterCode, e.ShiftCode, e.Poscode, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber })
                    .HasName("PK_ShiftHandoverMailtrip_1");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_ShiftHandoverMailtrip_Status");

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ShiftHandoverMailtrip)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandoverMailtrip_ShiftHandover1");

                entity.HasOne(d => d.Mailtrip)
                    .WithMany(p => p.ShiftHandoverMailtrip)
                    .HasForeignKey(d => new { d.FromPoscode, d.ToPoscode, d.MailTripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_ShiftHandoverMailtrip_Mailtrip");
            });

            modelBuilder.Entity<ShiftHandoverMailtripTransport>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.HandoverIndex, e.ShiftCode, e.CounterCode, e.TransportNumber, e.FromPoscode, e.TransportDate, e.TransportCode, e.Status })
                    .HasName("PK_ShiftHandoverMailtripTransport");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransportDate).HasMaxLength(8);

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.HasOne(d => d.MailtripTransport)
                    .WithMany(p => p.ShiftHandoverMailtripTransport)
                    .HasForeignKey(d => new { d.FromPoscode, d.TransportDate, d.TransportCode, d.TransportNumber })
                    .HasConstraintName("FK_ShiftHandoverMailtripTransport_MailtripTransport");

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ShiftHandoverMailtripTransport)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandoverMailtripTransport_ShiftHandover");
            });

            modelBuilder.Entity<ShiftHandoverPostBag>(entity =>
            {
                entity.HasKey(e => new { e.HandoverIndex, e.CounterCode, e.ShiftCode, e.Poscode, e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber, e.Status })
                    .HasName("PK_ShiftHandoverPostBag");

                entity.HasIndex(e => new { e.IsOpen, e.ShiftCodeOlder, e.MailTripNumber, e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.HandoverIndex, e.CounterCode, e.ShiftCode, e.Poscode, e.Status })
                    .HasName("_dta_index_ShiftHandoverPostBag_8_71671303__K11_K5_K6_K7_K8_K9_K10_K1_K2_K3_K4_K12_13_14");

                entity.HasIndex(e => new { e.ShiftCode, e.ShiftCodeOlder, e.Status, e.Poscode, e.CounterCode, e.HandoverIndex, e.IsOpen, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber, e.PostBagIndex })
                    .HasName("_dta_index_ShiftHandoverPostBag_7_71671303__K6_K7_K8_K9_K10_K11_K5_1_2_3_4_12_13_14");

                entity.Property(e => e.CounterCode).HasMaxLength(3);

                entity.Property(e => e.ShiftCode).HasMaxLength(1);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ShiftHandover)
                    .WithMany(p => p.ShiftHandoverPostBag)
                    .HasForeignKey(d => new { d.HandoverIndex, d.ShiftCode, d.CounterCode, d.Poscode })
                    .HasConstraintName("FK_ShiftHandoverPostBag_ShiftHandover1");

                entity.HasOne(d => d.PostBag)
                    .WithMany(p => p.ShiftHandoverPostBag)
                    .HasForeignKey(d => new { d.PostBagIndex, d.FromPoscode, d.ToPoscode, d.MailTripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_ShiftHandoverPostBag_PostBag");
            });

            modelBuilder.Entity<SlpDeliveryReport>(entity =>
            {
                entity.HasKey(e => new { e.ItemCode, e.DeliveryPoscode, e.DeliveryType })
                    .HasName("PK_SLP_DeliveryReport");

                entity.ToTable("SLP_DeliveryReport");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.DeliveryPoscode)
                    .HasColumnName("DeliveryPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Cod).HasColumnName("COD");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryRouteCode).HasMaxLength(10);

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.ItemTypeCode).HasMaxLength(2);

                entity.Property(e => e.PostmanCode).HasMaxLength(50);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.TransferDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sms>(entity =>
            {
                entity.ToTable("SMS");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessageContent).HasMaxLength(200);

                entity.Property(e => e.MtId).HasColumnName("MtID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(15);

                entity.Property(e => e.SendingTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Solution>(entity =>
            {
                entity.HasKey(e => e.SolutionCode)
                    .HasName("PK_Solution");

                entity.Property(e => e.SolutionCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.SolutionName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SolutionCustomer>(entity =>
            {
                entity.HasKey(e => new { e.SolutionCode, e.CustomerCode })
                    .HasName("PK_SolutionCustomer");

                entity.Property(e => e.SolutionCode).HasMaxLength(2);

                entity.Property(e => e.CustomerCode).HasMaxLength(17);

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.SolutionCustomer)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_SolutionCustomer_Customer");

                entity.HasOne(d => d.SolutionCodeNavigation)
                    .WithMany(p => p.SolutionCustomer)
                    .HasForeignKey(d => d.SolutionCode)
                    .HasConstraintName("FK_SolutionCustomer_Solution");
            });

            modelBuilder.Entity<StampMachine>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.StampMachineNumber })
                    .HasName("PK_StampMachine");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.StampMachineNumber).HasMaxLength(6);

                entity.Property(e => e.StampMachineName).HasMaxLength(200);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.StampMachine)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_StampMachine_POS");
            });

            modelBuilder.Entity<StampMachineFeight>(entity =>
            {
                entity.HasKey(e => new { e.Poscode, e.StampMachineNumber, e.DateInput })
                    .HasName("PK_StampMachineFeight");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.StampMachineNumber).HasMaxLength(6);

                entity.Property(e => e.DateInput).HasColumnType("datetime");

                entity.HasOne(d => d.StampMachine)
                    .WithMany(p => p.StampMachineFeight)
                    .HasForeignKey(d => new { d.Poscode, d.StampMachineNumber })
                    .HasConstraintName("FK_StampMachineFeight_StampMachine");
            });

            modelBuilder.Entity<StoreBehavior>(entity =>
            {
                entity.Property(e => e.StoreBehaviorId).ValueGeneratedNever();

                entity.Property(e => e.StoreBehaviorName).HasMaxLength(50);
            });

            modelBuilder.Entity<StoreDependOn>(entity =>
            {
                entity.HasKey(e => new { e.MessageTypeName, e.TableName, e.ColumnName, e.StoreDependOnTableName, e.StoreDependOnColumnName })
                    .HasName("PK_StoreDependOn_1");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.StoreDependOnTableName).HasMaxLength(100);

                entity.Property(e => e.StoreDependOnColumnName).HasMaxLength(100);

                entity.HasOne(d => d.Column)
                    .WithMany(p => p.StoreDependOnColumn)
                    .HasForeignKey(d => new { d.ColumnName, d.TableName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StoreDependOn_Column");

                entity.HasOne(d => d.MessageTypeTable)
                    .WithMany(p => p.StoreDependOn)
                    .HasForeignKey(d => new { d.MessageTypeName, d.TableName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StoreDependOn_MessageTypeTable");

                entity.HasOne(d => d.StoreDependOnNavigation)
                    .WithMany(p => p.StoreDependOnStoreDependOnNavigation)
                    .HasForeignKey(d => new { d.StoreDependOnColumnName, d.StoreDependOnTableName })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StoreDependOn_Column1");
            });

            modelBuilder.Entity<StoreType>(entity =>
            {
                entity.Property(e => e.StoreTypeId).ValueGeneratedNever();

                entity.Property(e => e.StoreTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SynchronizationHistory>(entity =>
            {
                entity.HasKey(e => e.MessageTypeName)
                    .HasName("PK_SynchronizationHistory");

                entity.Property(e => e.MessageTypeName).HasMaxLength(100);

                entity.Property(e => e.SyncDate).HasColumnType("datetime");

                entity.Property(e => e.SyncUser).HasMaxLength(50);
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK_Table");

                entity.Property(e => e.TableName).HasMaxLength(100);
            });

            modelBuilder.Entity<TargetCataloge>(entity =>
            {
                entity.HasKey(e => e.TargetCatalogeCode)
                    .HasName("PK_TargetCataloge");

                entity.Property(e => e.TargetCatalogeCode).HasMaxLength(50);

                entity.Property(e => e.TargetCatalogeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TargetCatalogeParentCode).HasMaxLength(50);

                entity.HasOne(d => d.TargetCatalogeParentCodeNavigation)
                    .WithMany(p => p.InverseTargetCatalogeParentCodeNavigation)
                    .HasForeignKey(d => d.TargetCatalogeParentCode)
                    .HasConstraintName("FK_TargetCataloge_TargetCataloge");
            });

            modelBuilder.Entity<TargetParameters>(entity =>
            {
                entity.HasKey(e => new { e.ParameterCode, e.TargetCode })
                    .HasName("PK_Parameters");

                entity.Property(e => e.ParameterCode).HasMaxLength(50);

                entity.Property(e => e.TargetCode).HasMaxLength(50);

                entity.Property(e => e.ParameterValue).HasMaxLength(500);

                entity.HasOne(d => d.TargetCodeNavigation)
                    .WithMany(p => p.TargetParameters)
                    .HasForeignKey(d => d.TargetCode)
                    .HasConstraintName("FK_Parameters_Tagets");
            });

            modelBuilder.Entity<TargetValues>(entity =>
            {
                entity.HasKey(e => new { e.TargetCode, e.Poscode, e.InsertDate })
                    .HasName("PK_TargetValues_1");

                entity.Property(e => e.TargetCode).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(50);

                entity.Property(e => e.InsertDate).HasMaxLength(8);

                entity.Property(e => e.Posdebt).HasColumnName("POSDebt");

                entity.Property(e => e.Vat).HasColumnName("VAT");

                entity.Property(e => e.Vatpercent).HasColumnName("VATPercent");

                entity.HasOne(d => d.TargetCodeNavigation)
                    .WithMany(p => p.TargetValues)
                    .HasForeignKey(d => d.TargetCode)
                    .HasConstraintName("FK_TagetValues_Tagets");
            });

            modelBuilder.Entity<Targets>(entity =>
            {
                entity.HasKey(e => e.TargetCode)
                    .HasName("PK_Tagets");

                entity.Property(e => e.TargetCode).HasMaxLength(50);

                entity.Property(e => e.TargetCatalogeCode).HasMaxLength(50);

                entity.Property(e => e.TargetName).HasMaxLength(150);

                entity.Property(e => e.UnitType).HasMaxLength(50);

                entity.Property(e => e.Vatformula).HasColumnName("VATFormula");

                entity.Property(e => e.VatpercentFormula).HasColumnName("VATPercentFormula");

                entity.HasOne(d => d.TargetCatalogeCodeNavigation)
                    .WithMany(p => p.Targets)
                    .HasForeignKey(d => d.TargetCatalogeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Targets_TargetCataloge");
            });

            modelBuilder.Entity<TraceItem>(entity =>
            {
                entity.HasKey(e => new { e.TraceIndex, e.ItemCode, e.Poscode })
                    .HasName("PK_TraceItem");

                entity.HasIndex(e => new { e.Note, e.Poscode, e.Status, e.StatusDesc, e.TraceDate, e.TraceIndex, e.TransferDate, e.TransferMachine, e.TransferPoscode, e.TransferStatus, e.TransferTimes, e.TransferUser, e.ItemCode })
                    .HasName("_dta_index_TraceItem_5_1499152386__K2_1_3_4_5_6_7_8_9_10_11_12_13");

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.StatusDesc).HasMaxLength(200);

                entity.Property(e => e.TraceDate).HasColumnType("datetime");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.TraceItem)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_TraceItem_Item");
            });

            modelBuilder.Entity<TracePostBag>(entity =>
            {
                entity.HasKey(e => new { e.PostBagIndex, e.FromPoscode, e.ToPoscode, e.MailTripType, e.ServiceCode, e.Year, e.MailTripNumber, e.Poscode, e.TraceIndex })
                    .HasName("PK_TracePostBag_1");

                entity.Property(e => e.FromPoscode)
                    .HasColumnName("FromPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ToPoscode)
                    .HasColumnName("ToPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.MailTripType).HasMaxLength(1);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.Year).HasMaxLength(8);

                entity.Property(e => e.MailTripNumber).HasMaxLength(4);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.StatusDescription).HasMaxLength(200);

                entity.Property(e => e.TraceDate).HasColumnType("datetime");

                entity.Property(e => e.TransferDate).HasColumnType("datetime");

                entity.Property(e => e.TransferMachine).HasMaxLength(50);

                entity.Property(e => e.TransferPoscode)
                    .HasColumnName("TransferPOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TransferUser).HasMaxLength(50);

                entity.HasOne(d => d.PostBag)
                    .WithMany(p => p.TracePostBag)
                    .HasForeignKey(d => new { d.PostBagIndex, d.FromPoscode, d.ToPoscode, d.MailTripType, d.ServiceCode, d.Year, d.MailTripNumber })
                    .HasConstraintName("FK_TracePostBag_PostBag");
            });

            modelBuilder.Entity<TraceTransactionsCollection>(entity =>
            {
                entity.HasKey(e => new { e.TraceIndex, e.TransactionsCollectionCode, e.ItemCode })
                    .HasName("PK_TraceTransactionsCollection");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TraceDate).HasColumnType("datetime");

                entity.HasOne(d => d.TransactionsCollection)
                    .WithMany(p => p.TraceTransactionsCollection)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode })
                    .HasConstraintName("FK_TraceTransactionsCollection_TransactionsCollection");
            });

            modelBuilder.Entity<TransactionCollectionChanged>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode, e.HandoverIndex, e.ChangePoscode, e.ChangeIndex })
                    .HasName("PK_TransactionCollectionChanged");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiverCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificatePlace).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.TransactionsCollectionChannel).HasMaxLength(50);

                entity.Property(e => e.TransactionsCollectionDate).HasColumnType("datetime");

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.TransactionCollectionChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TransactionCollectionChanged_ItemChanged");
            });

            modelBuilder.Entity<TransactionsCollection>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode })
                    .HasName("PK_TransactionsCollection_1");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.Codamount).HasColumnName("CODAmount");

                entity.Property(e => e.Codpostage).HasColumnName("CODPostage");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiverCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificatePlace).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.TransactionsCollectionChannel).HasMaxLength(50);

                entity.Property(e => e.TransactionsCollectionDate).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.TransactionsCollection)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_TransactionsCollection_Item");
            });

            modelBuilder.Entity<TransactionsCollectionDetail>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionIndex, e.TransactionsCollectionCode, e.ItemCode })
                    .HasName("PK_TransactionsCollectionDetail");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.Codamount).HasColumnName("CODAmount");

                entity.Property(e => e.Codpostage).HasColumnName("CODPostage");

                entity.Property(e => e.CodpostagePerson).HasColumnName("CODPostagePerson");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.TransactionsCollection)
                    .WithMany(p => p.TransactionsCollectionDetail)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode })
                    .HasConstraintName("FK_TransactionsCollectionDetail_TransactionsCollection");
            });

            modelBuilder.Entity<TransactionsPayment>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode, e.TransactionsPaymentCode })
                    .HasName("PK_TransactionsPayment");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.TransactionsPaymentCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentUserName).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiverCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificatePlace).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.TransactionsPaymentChannel).HasMaxLength(50);

                entity.HasOne(d => d.TransactionsCollection)
                    .WithMany(p => p.TransactionsPayment)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode })
                    .HasConstraintName("FK_TransactionsPayment_TransactionsCollection");
            });

            modelBuilder.Entity<TransactionsPaymentRevert>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode, e.TransactionsPaymentCode, e.TransactionsPaymentRevertCode })
                    .HasName("PK_TransactionsPaymentRevert");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.TransactionsPaymentCode).HasMaxLength(50);

                entity.Property(e => e.TransactionsPaymentRevertCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.RevertDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionsPaymentRevertChannel).HasMaxLength(50);

                entity.HasOne(d => d.TransactionsPayment)
                    .WithMany(p => p.TransactionsPaymentRevert)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode, d.TransactionsPaymentCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TransactionsPaymentRevert_TransactionsPayment");
            });

            modelBuilder.Entity<TransactionsReceiver>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode, e.TransactionsReceiverCode })
                    .HasName("PK_TransactionsReceiver");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.TransactionsReceiverCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.ReceiverAddress).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.ReceiverCertificateNumber).HasMaxLength(50);

                entity.Property(e => e.ReceiverCertificateOtherName).HasMaxLength(500);

                entity.Property(e => e.ReceiverCertificatePlace).HasMaxLength(500);

                entity.Property(e => e.ReceiverCustomerCode).HasMaxLength(17);

                entity.Property(e => e.ReceiverDateTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiverFullName).HasMaxLength(100);

                entity.Property(e => e.ReceiverTel).HasMaxLength(15);

                entity.Property(e => e.TransactionsPostman).HasMaxLength(100);

                entity.Property(e => e.TransactionsReceiverChannel).HasMaxLength(50);

                entity.Property(e => e.TransactionsReceiverDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionsUserName).HasMaxLength(50);

                entity.HasOne(d => d.TransactionsCollection)
                    .WithMany(p => p.TransactionsReceiver)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode })
                    .HasConstraintName("FK_TransactionsReceiver_TransactionsCollection");
            });

            modelBuilder.Entity<TransactionsReceiverRevert>(entity =>
            {
                entity.HasKey(e => new { e.TransactionsCollectionCode, e.ItemCode, e.TransactionsReceiverCode, e.TransactionsReceiverRevertCode })
                    .HasName("PK_TransactionsReceiverRevert");

                entity.Property(e => e.TransactionsCollectionCode).HasMaxLength(50);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.TransactionsReceiverCode).HasMaxLength(50);

                entity.Property(e => e.TransactionsReceiverRevertCode).HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(250);

                entity.Property(e => e.RevertDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionsReceiverRevertChannel).HasMaxLength(50);

                entity.HasOne(d => d.TransactionsReceiver)
                    .WithMany(p => p.TransactionsReceiverRevert)
                    .HasForeignKey(d => new { d.TransactionsCollectionCode, d.ItemCode, d.TransactionsReceiverCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_TransactionsReceiverRevert_TransactionsReceiver");
            });

            modelBuilder.Entity<TransitFreight>(entity =>
            {
                entity.HasKey(e => new { e.InternationalMailFreightRuleCode, e.ServiceCode, e.CountryCode, e.TransportTypeCode })
                    .HasName("PK_TransitFreight");

                entity.Property(e => e.InternationalMailFreightRuleCode).HasMaxLength(10);

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.CountryCode).HasMaxLength(3);

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.ExchangeRateCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.TransitFreight)
                    .HasForeignKey(d => d.CountryCode)
                    .HasConstraintName("FK_TransitFreight_Country");

                entity.HasOne(d => d.TransportTypeCodeNavigation)
                    .WithMany(p => p.TransitFreight)
                    .HasForeignKey(d => d.TransportTypeCode)
                    .HasConstraintName("FK_TransitFreight_TransportType");

                entity.HasOne(d => d.InternationalMailFreightRule)
                    .WithMany(p => p.TransitFreight)
                    .HasForeignKey(d => new { d.InternationalMailFreightRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_TransitFreight_InternationalMailFreightRule");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.HasKey(e => e.TransportCode)
                    .HasName("PK_Transport_Status");

                entity.HasIndex(e => e.Poscode)
                    .HasName("IX_Transport_POSCode");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Transport_Status");

                entity.Property(e => e.TransportCode).HasMaxLength(10);

                entity.Property(e => e.EndYear).HasColumnType("char(4)");

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.StartYear).HasColumnType("char(4)");

                entity.Property(e => e.TransportGroup)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.Transport)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_Transport_POS");

                entity.HasOne(d => d.TransportGroupNavigation)
                    .WithMany(p => p.Transport)
                    .HasForeignKey(d => d.TransportGroup)
                    .HasConstraintName("FK_Transport_TransportGroup");
            });

            modelBuilder.Entity<TransportGroup>(entity =>
            {
                entity.HasKey(e => e.TransportGroupCode)
                    .HasName("PK_TransportGroup");

                entity.Property(e => e.TransportGroupCode).HasMaxLength(2);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.TransportGroupName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransportType>(entity =>
            {
                entity.HasKey(e => e.TransportTypeCode)
                    .HasName("PK_TransportType");

                entity.Property(e => e.TransportTypeCode).HasMaxLength(1);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.TransportTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UndeliveryGuide>(entity =>
            {
                entity.HasKey(e => e.UndeliveryGuideCode)
                    .HasName("PK_UndeliveryGuide");

                entity.Property(e => e.UndeliveryGuideCode).ValueGeneratedNever();

                entity.Property(e => e.UndeliveryGuideName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.UnitCode)
                    .HasName("PK_Unit");

                entity.Property(e => e.UnitCode).HasMaxLength(6);

                entity.Property(e => e.CommuneCode).HasMaxLength(6);

                entity.Property(e => e.ParentUnitCode).HasMaxLength(6);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UnitTypeCode).HasMaxLength(3);

                entity.HasOne(d => d.CommuneCodeNavigation)
                    .WithMany(p => p.Unit)
                    .HasForeignKey(d => d.CommuneCode)
                    .HasConstraintName("FK_Unit_Commune");

                entity.HasOne(d => d.ParentUnitCodeNavigation)
                    .WithMany(p => p.InverseParentUnitCodeNavigation)
                    .HasForeignKey(d => d.ParentUnitCode)
                    .HasConstraintName("FK_Unit_Unit");

                entity.HasOne(d => d.UnitTypeCodeNavigation)
                    .WithMany(p => p.Unit)
                    .HasForeignKey(d => d.UnitTypeCode)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Unit_UnitType");
            });

            modelBuilder.Entity<UnitType>(entity =>
            {
                entity.HasKey(e => e.UnitTypeCode)
                    .HasName("PK_UnitType");

                entity.Property(e => e.UnitTypeCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.UnitTypeName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Poscode })
                    .HasName("PK_User");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.FullName).HasMaxLength(500);

                entity.Property(e => e.IsFromAd).HasColumnName("IsFromAD");

                entity.Property(e => e.IsPosadmin).HasColumnName("IsPOSAdmin");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.PassWord).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Tel).HasMaxLength(50);

                entity.Property(e => e.UnitCode).HasMaxLength(6);

                entity.HasOne(d => d.PoscodeNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.Poscode)
                    .HasConstraintName("FK_User_POS");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Username, e.Poscode })
                    .HasName("PK_UserGroup");

                entity.Property(e => e.GroupCode).HasMaxLength(10);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.HasOne(d => d.GroupCodeNavigation)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => d.GroupCode)
                    .HasConstraintName("FK_UserGroup_Group");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroup)
                    .HasForeignKey(d => new { d.Username, d.Poscode })
                    .HasConstraintName("FK_UserGroup_User1");
            });

            modelBuilder.Entity<UserTargets>(entity =>
            {
                entity.HasKey(e => new { e.UserName, e.Poscode, e.TargetCode })
                    .HasName("PK_UserTargets");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.TargetCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ValueAddedService>(entity =>
            {
                entity.HasKey(e => e.ValueAddedServiceCode)
                    .HasName("PK_ValueAddedService");

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.DllName).HasMaxLength(200);

                entity.Property(e => e.FormName).HasMaxLength(200);

                entity.Property(e => e.NameSpace).HasMaxLength(200);

                entity.Property(e => e.ShortcutKey).HasMaxLength(1);

                entity.Property(e => e.ValueAddedServiceName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ValueAddedServiceItem>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.ItemCode })
                    .HasName("PK_ValueAddedServiceItem");

                entity.HasIndex(e => e.ItemCode)
                    .HasName("_dta_index_ValueAddedServiceItem_6_1611152785__K3");

                entity.HasIndex(e => new { e.AddedDate, e.Freight, e.FreightVat, e.PhaseCode, e.Poscode, e.ServiceCode, e.ValueAddedServiceCode, e.ItemCode })
                    .HasName("_dta_index_ValueAddedServiceItem_5_1611152785__K3_1_2_4_5_6_7_8");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FreightVat).HasColumnName("FreightVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalFreightVat).HasColumnName("OriginalFreightVAT");

                entity.Property(e => e.OriginalSubFreightVat).HasColumnName("OriginalSubFreightVAT");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.SubFreightVat).HasColumnName("SubFreightVAT");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ValueAddedServiceItem)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ValueAddedServiceItem_Item");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.ValueAddedServiceItem)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ValueAddedServiceItem_VASUsing");
            });

            modelBuilder.Entity<ValueAddedServiceItemChanged>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.ItemCode, e.HandoverIndex, e.ChangePoscode, e.ChangeIndex })
                    .HasName("PK_ValueAddedServiceItemChanged");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.ChangePoscode)
                    .HasColumnName("ChangePOSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FreightVat).HasColumnName("FreightVAT");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OriginalFreightVat).HasColumnName("OriginalFreightVAT");

                entity.Property(e => e.OriginalSubFreightVat).HasColumnName("OriginalSubFreightVAT");

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.Property(e => e.Poscode)
                    .HasColumnName("POSCode")
                    .HasMaxLength(6);

                entity.Property(e => e.SubFreightVat).HasColumnName("SubFreightVAT");

                entity.HasOne(d => d.ItemChanged)
                    .WithMany(p => p.ValueAddedServiceItemChanged)
                    .HasForeignKey(d => new { d.ItemCode, d.HandoverIndex, d.ChangePoscode, d.ChangeIndex })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ValueAddedServiceItemChanged_ItemChanged");
            });

            modelBuilder.Entity<ValueAddedServiceItemUnUse>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.ItemCode })
                    .HasName("PK_ValueAddedServiceItemUnUse");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.ItemCode).HasMaxLength(13);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.ValueAddedServiceItemUnUse)
                    .HasForeignKey(d => d.ItemCode)
                    .HasConstraintName("FK_ValueAddedServiceItemUnUse_Item");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.ValueAddedServiceItemUnUse)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ValueAddedServiceItemUnUse_VASUsing");
            });

            modelBuilder.Entity<ValueAddedServicePhase>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode, e.PhaseCode })
                    .HasName("PK_ValueAddedServicePhase");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.PhaseCode).HasMaxLength(3);

                entity.HasOne(d => d.PhaseCodeNavigation)
                    .WithMany(p => p.ValueAddedServicePhase)
                    .HasForeignKey(d => d.PhaseCode)
                    .HasConstraintName("FK_ValueAddedServicePhase_Phase");

                entity.HasOne(d => d.Vasusing)
                    .WithMany(p => p.ValueAddedServicePhase)
                    .HasForeignKey(d => new { d.ServiceCode, d.ValueAddedServiceCode })
                    .HasConstraintName("FK_ValueAddedServicePhase_VASUsing");
            });

            modelBuilder.Entity<Vasproperty>(entity =>
            {
                entity.HasKey(e => new { e.PropertyCode, e.ValueAddedServiceCode })
                    .HasName("PK_VASProperty");

                entity.ToTable("VASProperty");

                entity.Property(e => e.PropertyCode).HasMaxLength(50);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.Control)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ControlValue).HasMaxLength(500);

                entity.Property(e => e.DataType).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.PropertyName).HasMaxLength(50);

                entity.HasOne(d => d.ValueAddedServiceCodeNavigation)
                    .WithMany(p => p.Vasproperty)
                    .HasForeignKey(d => d.ValueAddedServiceCode)
                    .HasConstraintName("FK_VASProperty_ValueAddedService");
            });

            modelBuilder.Entity<Vasusing>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.ValueAddedServiceCode })
                    .HasName("PK_VASUsing");

                entity.ToTable("VASUsing");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.ValueAddedServiceCode).HasMaxLength(3);

                entity.Property(e => e.DomesticExpression).HasMaxLength(200);

                entity.Property(e => e.InternationalExpression).HasMaxLength(200);

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.Vasusing)
                    .HasForeignKey(d => d.ServiceCode)
                    .HasConstraintName("FK_VASUsing_Service");

                entity.HasOne(d => d.ValueAddedServiceCodeNavigation)
                    .WithMany(p => p.Vasusing)
                    .HasForeignKey(d => d.ValueAddedServiceCode)
                    .HasConstraintName("FK_VASUsing_ValueAddedService");
            });

            modelBuilder.Entity<Version>(entity =>
            {
                entity.HasKey(e => e.VersionCode)
                    .HasName("PK_Version");

                entity.HasIndex(e => e.ReleasedDate)
                    .HasName("IX_Version_ReleasedDate");

                entity.HasIndex(e => e.Status)
                    .HasName("IX_Version_Status");

                entity.Property(e => e.VersionCode).HasMaxLength(10);

                entity.Property(e => e.ApplicationType).HasMaxLength(1);

                entity.Property(e => e.ReleasedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WholeQualityTarget>(entity =>
            {
                entity.HasKey(e => new { e.ServiceCode, e.QualityTargetRuleCode, e.TrasportTypeCode, e.RegionTypeCode })
                    .HasName("PK_WholeQualityTarget");

                entity.Property(e => e.ServiceCode).HasMaxLength(2);

                entity.Property(e => e.QualityTargetRuleCode).HasMaxLength(5);

                entity.Property(e => e.TrasportTypeCode).HasMaxLength(1);

                entity.Property(e => e.RegionTypeCode).HasMaxLength(1);

                entity.HasOne(d => d.RegionTypeCodeNavigation)
                    .WithMany(p => p.WholeQualityTarget)
                    .HasForeignKey(d => d.RegionTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WholeQualityTarget_RegionType");

                entity.HasOne(d => d.TrasportTypeCodeNavigation)
                    .WithMany(p => p.WholeQualityTarget)
                    .HasForeignKey(d => d.TrasportTypeCode)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_WholeQualityTarget_TransportType");

                entity.HasOne(d => d.QualityTargetRule)
                    .WithMany(p => p.WholeQualityTarget)
                    .HasForeignKey(d => new { d.QualityTargetRuleCode, d.ServiceCode })
                    .HasConstraintName("FK_WholeQualityTarget_QualityTargetRule");
            });
        }
    }
}