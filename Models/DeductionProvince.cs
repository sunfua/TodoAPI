﻿using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeductionProvince
    {
        public string DeductionCode { get; set; }
        public string ProvinceCode { get; set; }

        public virtual Deduction DeductionCodeNavigation { get; set; }
        public virtual Province ProvinceCodeNavigation { get; set; }
    }
}
