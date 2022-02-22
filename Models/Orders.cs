using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int TransactStatusId { get; set; }
        public bool Deleted { get; set; }
        public bool Paid { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int TotalMoney { get; set; }
        public int? PaymentId { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual TransactStatus TransactStatus { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
