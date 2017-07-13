using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class TargetParameters
    {
        public string ParameterCode { get; set; }
        public string ParameterValue { get; set; }
        public string TargetCode { get; set; }

        public virtual Targets TargetCodeNavigation { get; set; }
    }
}
