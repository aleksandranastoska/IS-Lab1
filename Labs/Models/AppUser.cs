﻿using Microsoft.AspNetCore.Identity;

namespace Labs.Models
{
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }   
    }
}
