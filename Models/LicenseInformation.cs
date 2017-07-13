using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class LicenseInformation
    {
        public int LicenseId { get; set; }
        public string Poscode { get; set; }
        public string PublicKey { get; set; }
        public string MachineName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
