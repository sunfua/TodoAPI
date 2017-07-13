using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CustomerBusinessDomain
    {
        public string Poscode { get; set; }
        public string CustomerCode { get; set; }
        public string BusinessDomainCode { get; set; }

        public virtual BusinessDomain BusinessDomainCodeNavigation { get; set; }
    }
}
