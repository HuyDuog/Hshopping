using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class AttributesPrices
    {
        public int AttributesPriceId { get; set; }
        public int? AttributeId { get; set; }
        public int? ProductId { get; set; }
        public int? Price { get; set; }
        public bool Active { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual Products Product { get; set; }
    }
}
