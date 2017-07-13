using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class BcnCommissiontodelivery
    {
        public int Id { get; set; }
        public int Levelweight { get; set; }
        public int Region { get; set; }
        public int IsSubOffice { get; set; }
        public string ItemTypeCode { get; set; }
        public string Vasicode { get; set; }
        public double EmsValue { get; set; }
        public bool? IsAdd { get; set; }
        public double? EmsValueTotal { get; set; }
    }
}
