using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public class ReplyTestRepository : IReplyRepository
	{
        private List<Reply> replies = new List<Reply>();
        public List<Reply> Replies { get { return replies; } }

        #region Methods

        public void AddReply(Reply reply)
        {
            Replies.Add(reply);
        }
        public IEnumerable<Reply> GetUserReplies(string userID)
        {
            List<Reply> userReplies = new List<Reply>();
            replies.ForEach(s =>
            {
                if (s.User.Username == userID)
                {
                    userReplies.Add(s);
                }
            });

            return userReplies;
        }
        public void CreateTestData(int cap)
        {
            for (int i = 0; i < cap; i++)
            {
                User u = new User() { Username = "User " + i.ToString() };
				Reply r = new Reply()
				{
					User = u,
					Header = "Header for Reply " + i.ToString(),
					Body = "Body for reply " + i.ToString()
				};
				replies.Add(r);
			}
        }

        #endregion Methods
    }
}
