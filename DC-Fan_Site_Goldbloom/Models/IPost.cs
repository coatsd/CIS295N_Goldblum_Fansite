using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DC_Fan_Site_Goldbloom.Models
{
    public interface IPost
	{
		User User { get; set; }
		string Header { get; set; }
		string Body { get; set; }
	}
}
