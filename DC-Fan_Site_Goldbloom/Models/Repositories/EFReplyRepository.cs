using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class EFReplyRepository : IReplyRepository
	{
		private AppDbContext context;

		public EFReplyRepository(AppDbContext cxt)
		{
			context = cxt;
		}

		public List<Reply> Replies { get { return context.Replies.ToList(); } }

		public void AddReply(Reply reply)
		{
			context.Replies.Add(reply);
			context.SaveChanges();
		}

		public IEnumerable<Reply> GetUserReplies(string userName)
		{
			IEnumerable<Reply> userReplies = from r in context.Replies
											 where r.User.Username == userName
											 select r;
			return userReplies;
		}
	}
}
