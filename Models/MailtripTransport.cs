using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class MailtripTransport
    {
        public MailtripTransport()
        {
            MailtripTransportBc37 = new HashSet<MailtripTransportBc37>();
            MailtripTransportTrace = new HashSet<MailtripTransportTrace>();
            ShiftHandoverMailtripTransport = new HashSet<ShiftHandoverMailtripTransport>();
        }

        public string FromPoscode { get; set; }
        public string TransportDate { get; set; }
        public string TransportCode { get; set; }
        public string DriverCode { get; set; }
        public string EcortCode { get; set; }
        public byte? Status { get; set; }
        public DateTime? GoingDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string CommandNumber { get; set; }
        public string CommandContent { get; set; }
        public string MailRouteScheduleCode { get; set; }
        public string MailRouteCode { get; set; }
        public string TransportAffairCode { get; set; }
        public byte? CommandType { get; set; }
        public string StartingCode { get; set; }
        public string DestinationCode { get; set; }
        public double? Distance { get; set; }
        public DateTime? InitialDate { get; set; }
        public byte? MailrouteType { get; set; }
        public DateTime? CommandDate { get; set; }
        public string CreateUser { get; set; }
        public string ConfirmUsser { get; set; }
        public int TransportNumber { get; set; }
        public byte? Direct { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<MailtripTransportBc37> MailtripTransportBc37 { get; set; }
        public virtual ICollection<MailtripTransportTrace> MailtripTransportTrace { get; set; }
        public virtual ICollection<ShiftHandoverMailtripTransport> ShiftHandoverMailtripTransport { get; set; }
        public virtual Transport TransportCodeNavigation { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual MailRouteSchedule MailRouteSchedule { get; set; }
    }
}
