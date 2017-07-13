using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ChemicalType
    {
        public ChemicalType()
        {
            DetailItem = new HashSet<DetailItem>();
        }

        public string ChemicalTypeCode { get; set; }
        public string ChemicalTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<DetailItem> DetailItem { get; set; }
    }
}
