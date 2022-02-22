using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class Attributes
    {
        public Attributes()
        {
            AttributesPrices = new HashSet<AttributesPrices>();
        }

        public int AttributeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AttributesPrices> AttributesPrices { get; set; }
    }
}
