using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
