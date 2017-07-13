using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class CauseCustomer
    {
        public string CauseCode { get; set; }
        public string CustomerCode { get; set; }

        public virtual Cause CauseCodeNavigation { get; set; }
        public virtual Customer CustomerCodeNavigation { get; set; }
    }
}
