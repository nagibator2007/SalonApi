using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Product
    {
        public Product()
        {
            AttachedProductAttachedProductNavigation = new HashSet<AttachedProduct>();
            AttachedProductMainProduct = new HashSet<AttachedProduct>();
            ProductPhoto = new HashSet<ProductPhoto>();
            ProductSale = new HashSet<ProductSale>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string MainImagePath { get; set; }
        public bool IsActive { get; set; }
        public int? ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<AttachedProduct> AttachedProductAttachedProductNavigation { get; set; }
        public virtual ICollection<AttachedProduct> AttachedProductMainProduct { get; set; }
        public virtual ICollection<ProductPhoto> ProductPhoto { get; set; }
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
