using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Story : IPost
    {
        public int StoryID { get; set; }
        public User User { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public List<Reply> Replies { get; set; }
    }
}
