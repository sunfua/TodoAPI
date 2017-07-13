using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class PostBagType
    {
        public PostBagType()
        {
            PostBag = new HashSet<PostBag>();
        }

        public string PostBagTypeCode { get; set; }
        public string PostBagTypeName { get; set; }
        public string Description { get; set; }
        public string ServiceCode { get; set; }
        public bool? IsPostBag { get; set; }
        public byte? Type { get; set; }

        public virtual ICollection<PostBag> PostBag { get; set; }
        public virtual Service ServiceCodeNavigation { get; set; }
    }
}
