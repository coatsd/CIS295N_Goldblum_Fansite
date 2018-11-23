using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class User
    {
        // made protected in case I want to make an Admin class that inherits from User
        public int UserID { get; set; }
        public bool IsSignedIn { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
