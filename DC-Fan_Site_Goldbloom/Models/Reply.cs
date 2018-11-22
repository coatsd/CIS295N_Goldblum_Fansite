using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DC_Fan_Site_Goldbloom.Models;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Reply : IPost
    {
        public int ReplyID { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
    }
}
