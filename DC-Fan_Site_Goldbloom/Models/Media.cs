using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Media
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
    }
}
