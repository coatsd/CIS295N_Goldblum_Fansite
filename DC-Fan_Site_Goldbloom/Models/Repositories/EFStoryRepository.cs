using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class EFStoryRepository : IStoryRepository
	{
		private AppDbContext context;

		public EFStoryRepository(AppDbContext cxt)
		{
			context = cxt;
		}

		public List<Story> Stories { get { return context.Stories.ToList(); } }

		public void AddStory(Story story)
		{
			context.Stories.Add(story);
			context.SaveChanges();
		}

		public IEnumerable<Story> GetUserStories(string userName)
		{
			IEnumerable<Story> userStories = from s in context.Stories where
											 s.User.Username == userName
											 select s;
			return userStories;
		}

		public IEnumerable<Story> GetStoriesByHeader(string header)
		{
			IEnumerable<Story> stories = from s in context.Stories
										 where s.Header == header
										 select s;

			return stories;
		}

		public IEnumerable<Story> GetStoriesByBody(string body)
		{
			IEnumerable<Story> stories = from s in context.Stories
										 where s.Body == body
										 select s;
			return stories;
		}

        public void CreateTestData(int cap)
        {

        }
	}
}
