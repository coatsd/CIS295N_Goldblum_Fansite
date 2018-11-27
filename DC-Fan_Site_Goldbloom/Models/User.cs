using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class User
    {
        public int UserID { get; set; }
        public bool IsSignedIn { get; set; }

		[Required]
        public string Username { get; set; }

		[MinLength(6)]
		[Required]
        public string Password { get; set; }
    }
}
