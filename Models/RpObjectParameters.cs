using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RpObjectParameters
    {
        public string StoreProcedureName { get; set; }
        public string ParameterName { get; set; }
        public string ParameterValue { get; set; }

        public virtual RpObjectsFillReportsData StoreProcedureNameNavigation { get; set; }
    }
}
