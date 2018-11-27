using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Media
    {
        public int MediaID { get; set; }

		[Required]
        public string Title { get; set; }

		[Required]
        public string Artist { get; set; }
        public string Type { get; set; }

		[Required]
        public string Link { get; set; }
    }
}
