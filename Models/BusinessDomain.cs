﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class BusinessDomain
    {
        public BusinessDomain()
        {
            CustomerBusinessDomain = new HashSet<CustomerBusinessDomain>();
        }

        public string BusinessDomainCode { get; set; }
        public string BusinessDomainName { get; set; }

        public virtual ICollection<CustomerBusinessDomain> CustomerBusinessDomain { get; set; }
    }
}
