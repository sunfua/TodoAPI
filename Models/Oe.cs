using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Oe
    {
        public string Oecode { get; set; }
        public string CountryCode { get; set; }
        public string Oename { get; set; }

        public virtual Country CountryCodeNavigation { get; set; }
    }
}
