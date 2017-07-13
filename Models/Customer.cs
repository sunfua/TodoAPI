using System;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CauseCustomer = new HashSet<CauseCustomer>();
            CustomerContract = new HashSet<CustomerContract>();
            OnlineOrder = new HashSet<OnlineOrder>();
            Order = new HashSet<Order>();
            Payment = new HashSet<Payment>();
            SolutionCustomer = new HashSet<SolutionCustomer>();
        }

        public string CustomerCode { get; set; }
        public string Poscode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string TaxCode { get; set; }
        public string IdentificationNumber { get; set; }
        public string Note { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual ICollection<CauseCustomer> CauseCustomer { get; set; }
        public virtual ICollection<CustomerContract> CustomerContract { get; set; }
        public virtual ICollection<OnlineOrder> OnlineOrder { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<SolutionCustomer> SolutionCustomer { get; set; }
    }
}
