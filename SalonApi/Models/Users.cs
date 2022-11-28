using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Users
    {
        public int? Idrole { get; set; }
        public string UserName { get; set; }
        public string UserLastName { get; set; }
        public string UserOtherName { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }

        public virtual Roles IdroleNavigation { get; set; }
    }
}
