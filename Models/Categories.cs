﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HShopping.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
        public int? Levels { get; set; }
        public string Title { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
