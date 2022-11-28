using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Services
    {
        public Services()
        {
            ClientServices = new HashSet<ClientServices>();
            ServicePhotos = new HashSet<ServicePhotos>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string Description { get; set; }
        public double? Discount { get; set; }
        public string MainImagePath { get; set; }
        public int? CategoryId { get; set; }

        public virtual ServiceCategoryes Category { get; set; }
        public virtual ICollection<ClientServices> ClientServices { get; set; }
        public virtual ICollection<ServicePhotos> ServicePhotos { get; set; }
    }
}
