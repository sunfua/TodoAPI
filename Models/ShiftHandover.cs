using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ShiftHandover
    {
        public ShiftHandover()
        {
            ServiceItemRemaining = new HashSet<ServiceItemRemaining>();
            ShiftHandoverBc37 = new HashSet<ShiftHandoverBc37>();
            ShiftHandoverItem = new HashSet<ShiftHandoverItem>();
            ShiftHandoverMailtrip = new HashSet<ShiftHandoverMailtrip>();
            ShiftHandoverMailtripTransport = new HashSet<ShiftHandoverMailtripTransport>();
            ShiftHandoverPostBag = new HashSet<ShiftHandoverPostBag>();
        }

        public int HandoverIndex { get; set; }
        public string ShiftCode { get; set; }
        public string GivingUsername { get; set; }
        public string RecevingUsername { get; set; }
        public DateTime? HandoverTime { get; set; }
        public string CounterCode { get; set; }
        public DateTime? StartDate { get; set; }
        public string Poscode { get; set; }
        public int? Before { get; set; }
        public int? After { get; set; }
        public string TransferMachine { get; set; }
        public string TransferUser { get; set; }
        public string TransferPoscode { get; set; }
        public DateTime? TransferDate { get; set; }
        public bool? TransferStatus { get; set; }
        public int? TransferTimes { get; set; }
        public int? OldDataItemClosingIn { get; set; }
        public double? OldDataItemWeightClosingIn { get; set; }
        public int? OldDataPostbagClosingIn { get; set; }
        public double? OldDataPostbagWeightClosingIn { get; set; }
        public int? OldDataItemClosingOut { get; set; }
        public double? OldDataItemWeightClosingOut { get; set; }
        public int? OldDataItemOpened { get; set; }
        public double? OldDataItemWeightOpened { get; set; }
        public int? OldDataPostbagOpened { get; set; }
        public double? OldDataPostbagWeightOpened { get; set; }
        public int? OldDataItemOpenedC { get; set; }
        public double? OldDataItemWeightOpenedC { get; set; }
        public int? OldDataItemOpenedR { get; set; }
        public double? OldDataItemWeightOpenedR { get; set; }
        public int? OldDataItemOpenedE { get; set; }
        public double? OldDataItemWeightOpenedE { get; set; }
        public int? OldDataItemOpenedU { get; set; }
        public double? OldDataItemWeightOpenedU { get; set; }
        public int? OldDataItemOpenedK { get; set; }
        public double? OldDataItemWeightOpenedK { get; set; }
        public int? OldDataItemOpenedT { get; set; }
        public double? OldDataItemWeightOpenedT { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<ServiceItemRemaining> ServiceItemRemaining { get; set; }
        public virtual ICollection<ShiftHandoverBc37> ShiftHandoverBc37 { get; set; }
        public virtual ICollection<ShiftHandoverItem> ShiftHandoverItem { get; set; }
        public virtual ICollection<ShiftHandoverMailtrip> ShiftHandoverMailtrip { get; set; }
        public virtual ICollection<ShiftHandoverMailtripTransport> ShiftHandoverMailtripTransport { get; set; }
        public virtual ICollection<ShiftHandoverPostBag> ShiftHandoverPostBag { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
        public virtual Shift Shift { get; set; }
    }
}
