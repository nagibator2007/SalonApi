using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class ServiceCategoryes
    {
        public ServiceCategoryes()
        {
            Services = new HashSet<Services>();
        }

        public int CategoryId { get; set; }
        public string CategoryTitle { get; set; }
        public byte[] CategoryImage { get; set; }

        public virtual ICollection<Services> Services { get; set; }
    }
}
