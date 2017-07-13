using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class NearProvince
    {
        public string ProvinceCode { get; set; }
        public string RegionCode { get; set; }

        public virtual Province ProvinceCodeNavigation { get; set; }
        public virtual Region RegionCodeNavigation { get; set; }
    }
}
