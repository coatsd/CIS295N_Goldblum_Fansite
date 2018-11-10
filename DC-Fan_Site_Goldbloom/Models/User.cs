using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class User
    {
        // made protected in case I want to make an Admin class that inherits from User
        protected string UserID { get; set; }
        protected bool IsSignedIn { get; set; }
        public string Username { get; set; }
        protected string Password { get; set; }
    }
}
