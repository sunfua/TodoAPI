using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Continent
    {
        public Continent()
        {
            Country = new HashSet<Country>();
            InternationalAirSurchargeFreight = new HashSet<InternationalAirSurchargeFreight>();
        }

        public string ContinentCode { get; set; }
        public string ContinentName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<InternationalAirSurchargeFreight> InternationalAirSurchargeFreight { get; set; }
    }
}
