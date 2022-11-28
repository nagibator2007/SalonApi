using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Client = new HashSet<Client>();
        }

        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Client> Client { get; set; }
    }
}
