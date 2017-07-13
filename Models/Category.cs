using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Category
    {
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ServiceCode { get; set; }
    }
}
