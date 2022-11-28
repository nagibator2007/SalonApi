using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SalonApi.Models
{
    public partial class Tag
    {
        public Tag()
        {
            TagOfClient = new HashSet<TagOfClient>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }

        public virtual ICollection<TagOfClient> TagOfClient { get; set; }
    }
}
