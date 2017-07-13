using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeleteParameter
    {
        public string MessageTypeName { get; set; }
        public string TableName { get; set; }
        public string DeleteParameterName { get; set; }
        public string DataType { get; set; }
    }
}
