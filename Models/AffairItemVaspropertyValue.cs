using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class AffairItemVaspropertyValue
    {
        public int AffairIndex { get; set; }
        public string ItemCode { get; set; }
        public string PropertyCode { get; set; }
        public string ValueAddedServiceCode { get; set; }
        public string Value { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }
    }
}
