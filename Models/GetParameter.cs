using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class GetParameter
    {
        public string MessageTypeName { get; set; }
        public string TableName { get; set; }
        public string GetParameterName { get; set; }
        public string DataType { get; set; }

        public virtual MessageTypeTable MessageTypeTable { get; set; }
    }
}
