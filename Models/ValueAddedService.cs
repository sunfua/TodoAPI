using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class ValueAddedService
    {
        public ValueAddedService()
        {
            InternationalValueAddedServiceCountryFreight = new HashSet<InternationalValueAddedServiceCountryFreight>();
            MoneyOrderValueAddedService = new HashSet<MoneyOrderValueAddedService>();
            Vasproperty = new HashSet<Vasproperty>();
            Vasusing = new HashSet<Vasusing>();
        }

        public string ValueAddedServiceCode { get; set; }
        public string ValueAddedServiceName { get; set; }
        public string Description { get; set; }
        public string FormName { get; set; }
        public string DllName { get; set; }
        public string NameSpace { get; set; }
        public bool? IsActive { get; set; }
        public int? OrderIndex { get; set; }
        public string ShortcutKey { get; set; }

        public virtual ICollection<InternationalValueAddedServiceCountryFreight> InternationalValueAddedServiceCountryFreight { get; set; }
        public virtual ICollection<MoneyOrderValueAddedService> MoneyOrderValueAddedService { get; set; }
        public virtual ICollection<Vasproperty> Vasproperty { get; set; }
        public virtual ICollection<Vasusing> Vasusing { get; set; }
    }
}
