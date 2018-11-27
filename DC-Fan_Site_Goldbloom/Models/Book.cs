using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Book
    {
        public int BookID { get; set; }

		[Required]
        public string Title { get; set; }

		[Required]
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string PubDate { get; set; }

		[Required]
        public string Link { get; set; }
    }
}
