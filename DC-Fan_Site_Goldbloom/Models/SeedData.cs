using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class SeedData
	{
		public void EnsurePopulated(IApplicationBuilder app)
		{
			AppDbContext context = app.ApplicationServices
				.GetRequiredService<AppDbContext>();
			context.Database.Migrate();

			if (!context.Stories.Any())
			{
				List<Reply> replies = new List<Reply>
				{
					new Reply { Header = "Nothing much", 
							   Body = "How about you?" },
					new Reply { Header = "Hi!!!", Body = "I'm good!" },
					new Reply { Header = "Yes", Body = "Jeff Goldblum is cool"},
					new Reply { Header = "Of course!",
							   Body = "That's why he's in so many movies" },
					new Reply { Header = "Why Did you post this?",
								Body = "This isn't relevant" },
					new Reply { Header = "That it is!", 
								Body = "Thanks for pointing that out" },
					new Reply { Header = "That's Rad!",
								Body = "Kinda weird though." },
					new Reply { Header = "", Body = "" },
					new Reply { Header = "", Body = "" },
					new Reply { Header = "", Body = "" }
				};

				context.Stories.AddRange(
					new Story { Header = "Hi", Body = "What's up?" },
					new Story { Header = "Jeff Goldblum", Body = "Is Cool" },
					new Story { Header = "Subject", Body = "Verb" },
					new Story { Header = "What this site is about:",
								Body = "This site is about Jeff Goldblum"},
					new Story { Header = "I'm cool",
								Body = "Jeff Goldblum signed my forehead!"}
					);
			}
		}
	}
}
