using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class Products
    {
        public Products()
        {
            AttributesPrices = new HashSet<AttributesPrices>();
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public int? CatId { get; set; }
        public int? Price { get; set; }
        public int? Discount { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public bool BestSellers { get; set; }
        public bool Active { get; set; }
        public string Tags { get; set; }
        public string Title { get; set; }
        public int? UnitsInStock { get; set; }

        public virtual Categories Cat { get; set; }
        public virtual ICollection<AttributesPrices> AttributesPrices { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
