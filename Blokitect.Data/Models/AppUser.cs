using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Blokitect.Data.Models.Enums;

namespace Blokitect.Data.Models
{
    // Contains user data 
    public class AppUser : IdentityUser
    {
        public UserRole UserRole { get; set; }

        public bool IsSignedIn { get; set; }

        public AppUser Supervisor { get; set; }

        public string SupervisorId { get; set; }

        public bool IsSupervisor 
        { 
            get 
            {
                return this.Supervisor == null;
            } 
        }
    }
}
