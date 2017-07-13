using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ServiceType
    {
        public ServiceType()
        {
            Service = new HashSet<Service>();
        }

        public string ServiceTypeCode { get; set; }
        public string ServiceTypeName { get; set; }
        public string Description { get; set; }
        public string ServiceTypeParentCode { get; set; }

        public virtual ICollection<Service> Service { get; set; }
        public virtual ServiceType ServiceTypeParentCodeNavigation { get; set; }
        public virtual ICollection<ServiceType> InverseServiceTypeParentCodeNavigation { get; set; }
    }
}
