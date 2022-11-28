using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class ClientServices
    {
        public ClientServices()
        {
            DocumentByService = new HashSet<DocumentByService>();
            ProductSale = new HashSet<ProductSale>();
        }

        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public DateTime StartTime { get; set; }
        public string Comment { get; set; }

        public virtual Client Client { get; set; }
        public virtual Services Service { get; set; }
        public virtual ICollection<DocumentByService> DocumentByService { get; set; }
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
