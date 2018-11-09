﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DC_Fan_Site_Goldbloom.Models;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Reply
    {
        public User User { get; }
        public int Rating { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}