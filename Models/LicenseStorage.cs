using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class LicenseStorage
    {
        public int ApplicationId { get; set; }
        public string Posname { get; set; }
        public string Email { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? Count { get; set; }
        public string Comment { get; set; }
    }
}
