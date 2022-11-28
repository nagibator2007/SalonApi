using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientServices = new HashSet<ClientServices>();
            TagOfClient = new HashSet<TagOfClient>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string GenderCode { get; set; }
        public string PhotoPath { get; set; }

        public virtual Gender GenderCodeNavigation { get; set; }
        public virtual ICollection<ClientServices> ClientServices { get; set; }
        public virtual ICollection<TagOfClient> TagOfClient { get; set; }
    }
}
