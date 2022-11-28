using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class AttachedProduct
    {
        public int MainProductId { get; set; }
        public int AttachedProductId { get; set; }

        public virtual Product AttachedProductNavigation { get; set; }
        public virtual Product MainProduct { get; set; }
    }
}
