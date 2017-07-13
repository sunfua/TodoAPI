using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Pos
    {
        public Pos()
        {
            BatchPos = new HashSet<BatchPos>();
            Claim = new HashSet<Claim>();
            Counter = new HashSet<Counter>();
            DeductionPos = new HashSet<DeductionPos>();
            DeliveryRoute = new HashSet<DeliveryRoute>();
            Driver = new HashSet<Driver>();
            InternationalCompensateRule = new HashSet<InternationalCompensateRule>();
            Item = new HashSet<Item>();
            MailRoute = new HashSet<MailRoute>();
            MailRoutePos = new HashSet<MailRoutePos>();
            OfflinePosOfflinePoscodeNavigation = new HashSet<OfflinePos>();
            OfflinePosOnlinePoscodeNavigation = new HashSet<OfflinePos>();
            Posconfiguration = new HashSet<Posconfiguration>();
            PosfreightRegion = new HashSet<PosfreightRegion>();
            PosprintConfiguration = new HashSet<PosprintConfiguration>();
            Posservice = new HashSet<Posservice>();
            ReceiverDomesticCompensate = new HashSet<ReceiverDomesticCompensate>();
            ReceiverInternationalCompensate = new HashSet<ReceiverInternationalCompensate>();
            RevenueSharing = new HashSet<RevenueSharing>();
            Section = new HashSet<Section>();
            SenderDomesticCompensate = new HashSet<SenderDomesticCompensate>();
            Server = new HashSet<Server>();
            ServicePosconfiguration = new HashSet<ServicePosconfiguration>();
            ServiceSupplying = new HashSet<ServiceSupplying>();
            Shift = new HashSet<Shift>();
            ShiftHandover = new HashSet<ShiftHandover>();
            StampMachine = new HashSet<StampMachine>();
            Transport = new HashSet<Transport>();
            User = new HashSet<User>();
        }

        public string Poscode { get; set; }
        public string Posname { get; set; }
        public string Address { get; set; }
        public string AddressCode { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Ip { get; set; }
        public string DatabaseServer { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }
        public string PostypeCode { get; set; }
        public string ProvinceCode { get; set; }
        public string ServiceServer { get; set; }
        public int? ServicePort { get; set; }
        public string PoslevelCode { get; set; }
        public string CommuneCode { get; set; }
        public bool? IsOffline { get; set; }
        public string UnitCode { get; set; }
        public byte? Status { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual ICollection<BatchPos> BatchPos { get; set; }
        public virtual ICollection<Claim> Claim { get; set; }
        public virtual ICollection<Counter> Counter { get; set; }
        public virtual ICollection<DeductionPos> DeductionPos { get; set; }
        public virtual ICollection<DeliveryRoute> DeliveryRoute { get; set; }
        public virtual ICollection<Driver> Driver { get; set; }
        public virtual ICollection<InternationalCompensateRule> InternationalCompensateRule { get; set; }
        public virtual ICollection<Item> Item { get; set; }
        public virtual ICollection<MailRoute> MailRoute { get; set; }
        public virtual ICollection<MailRoutePos> MailRoutePos { get; set; }
        public virtual ICollection<OfflinePos> OfflinePosOfflinePoscodeNavigation { get; set; }
        public virtual ICollection<OfflinePos> OfflinePosOnlinePoscodeNavigation { get; set; }
        public virtual ICollection<Posconfiguration> Posconfiguration { get; set; }
        public virtual ICollection<PosfreightRegion> PosfreightRegion { get; set; }
        public virtual ICollection<PosprintConfiguration> PosprintConfiguration { get; set; }
        public virtual ICollection<Posservice> Posservice { get; set; }
        public virtual ICollection<ReceiverDomesticCompensate> ReceiverDomesticCompensate { get; set; }
        public virtual ICollection<ReceiverInternationalCompensate> ReceiverInternationalCompensate { get; set; }
        public virtual ICollection<RevenueSharing> RevenueSharing { get; set; }
        public virtual ICollection<Section> Section { get; set; }
        public virtual ICollection<SenderDomesticCompensate> SenderDomesticCompensate { get; set; }
        public virtual ICollection<Server> Server { get; set; }
        public virtual ICollection<ServicePosconfiguration> ServicePosconfiguration { get; set; }
        public virtual ICollection<ServiceSupplying> ServiceSupplying { get; set; }
        public virtual ICollection<Shift> Shift { get; set; }
        public virtual ICollection<ShiftHandover> ShiftHandover { get; set; }
        public virtual ICollection<StampMachine> StampMachine { get; set; }
        public virtual ICollection<Transport> Transport { get; set; }
        public virtual ICollection<User> User { get; set; }
        public virtual Poslevel PoslevelCodeNavigation { get; set; }
        public virtual Postype PostypeCodeNavigation { get; set; }
        public virtual Unit UnitCodeNavigation { get; set; }
    }
}
