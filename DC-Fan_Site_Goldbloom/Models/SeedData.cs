using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace DC_Fan_Site_Goldbloom.Models
{
    public static class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			AppDbContext context = app.ApplicationServices
				.GetRequiredService<AppDbContext>();
			context.Database.Migrate();

			if (!context.Stories.Any())
			{
				List<Reply> replies1 = new List<Reply>
				{
					new Reply { Header = "Nothing much", 
							   Body = "How about you?" },
					new Reply { Header = "Hi!!!", Body = "I'm good!" },
				};

                List<Reply> replies2 = new List<Reply>
                {
                    new Reply { Header = "Yes", Body = "Jeff Goldblum is cool"},
                    new Reply { Header = "Of course!",
                               Body = "That's why he's in so many movies" }
                };

                List<Reply> replies3 = new List<Reply>
                {
                    new Reply { Header = "Why Did you post this?",
                                Body = "This isn't relevant" },
                    new Reply { Header = "You", Body = "Suck" }

                };

                List<Reply> replies4 = new List<Reply>
                {
                    new Reply { Header = "That it is!",
                                Body = "Thanks for pointing that out" },
                    new Reply { Header = "Duh", Body = "Of course it is." }
                };

                List<Reply> replies5 = new List<Reply>
                {
                    new Reply { Header = "That's Rad!",
                                Body = "Kinda weird though." },
                    new Reply { Header = "You're a freak, Dude",
                                Body = "Why would you have him sign your forehead?" },
                };

				context.Stories.AddRange(
					new Story { Header = "Hi", Body = "What's up?",
                                Replies = replies1 },
					new Story { Header = "Jeff Goldblum", Body = "Is Cool",
                                Replies = replies2},
					new Story { Header = "Subject", Body = "Verb",
                                Replies = replies3},
					new Story { Header = "What this site is about:",
								Body = "This site is about Jeff Goldblum",
                                Replies = replies4},
					new Story { Header = "I'm cool",
								Body = "Jeff Goldblum signed my forehead!",
                                Replies = replies5}
					);
			}

            if (!context.Medias.Any())
            {
                context.Medias.AddRange(
                    new Media { Title = "Hahahrawr",
                                Artist = "Flip-Shot",
                                Type = "Video",
                                Link = "https://www.youtube.com/watch?v=wJelEXaPhJ8"}
                    );
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book { Title = "Do I Hate Being Right All the Time: The Jeff Goldblum Activity Book",
                               Author = "Belly Kids", Genre = "Graphic/activity",
                               Publisher = "Belly Kids", PubDate = "2/7/2017",
                               Link = "https://www.barnesandnoble.com/w/do-i-hate-being-right-all-the-time-belly-kids/1126014085"
                    });
            }

            context.SaveChanges();
		}
	}
}
