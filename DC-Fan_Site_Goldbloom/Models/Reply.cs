using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DC_Fan_Site_Goldbloom.Models;
using System.ComponentModel.DataAnnotations;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class Reply : IPost
    {
        public int ReplyID { get; set; }
        public int StoryID { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }

		[MaxLength(50)]
		[Required]
        public string Header { get; set; }

		[MinLength(3)]
		[Required]
        public string Body { get; set; }
    }
}
