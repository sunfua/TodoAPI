using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TransportType
    {
        public TransportType()
        {
            InternationalFreightSharing = new HashSet<InternationalFreightSharing>();
            MailRoute = new HashSet<MailRoute>();
            TransitFreight = new HashSet<TransitFreight>();
            WholeQualityTarget = new HashSet<WholeQualityTarget>();
        }

        public string TransportTypeCode { get; set; }
        public string TransportTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<InternationalFreightSharing> InternationalFreightSharing { get; set; }
        public virtual ICollection<MailRoute> MailRoute { get; set; }
        public virtual ICollection<TransitFreight> TransitFreight { get; set; }
        public virtual ICollection<WholeQualityTarget> WholeQualityTarget { get; set; }
    }
}
