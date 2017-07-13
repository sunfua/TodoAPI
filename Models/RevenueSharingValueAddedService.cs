﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class RevenueSharingValueAddedService
    {
        public string ProvinceCode { get; set; }
        public DateTime ValueDate { get; set; }
        public double? InProvinceA { get; set; }
        public double? InProvinceB { get; set; }
        public double? OutProvince { get; set; }
        public double? International { get; set; }
        public string ValueAddedService { get; set; }
        public string ServiceCode { get; set; }
    }
}
