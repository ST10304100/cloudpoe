﻿using Microsoft.AspNetCore.Identity;

namespace KhumaloCraft.Models
{
   
        public class ApplicationUser : IdentityUser
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
    }

