using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class DeductionPos
    {
        public string Poscode { get; set; }
        public string DeductionCode { get; set; }

        public virtual Deduction DeductionCodeNavigation { get; set; }
        public virtual Pos PoscodeNavigation { get; set; }
    }
}
