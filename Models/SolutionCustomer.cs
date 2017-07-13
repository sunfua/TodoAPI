using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class SolutionCustomer
    {
        public string SolutionCode { get; set; }
        public string CustomerCode { get; set; }

        public virtual Customer CustomerCodeNavigation { get; set; }
        public virtual Solution SolutionCodeNavigation { get; set; }
    }
}
