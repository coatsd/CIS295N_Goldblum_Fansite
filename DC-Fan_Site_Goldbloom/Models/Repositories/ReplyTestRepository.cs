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

        public void AddStory(Reply reply)
        {
            Replies.Add(reply);
        }
        public List<Reply> GetUserReplies(string userID)
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

                List<Reply> replies = new List<Reply>();
                for (int j = 0; j < 2; j++)
                {
                    Reply r = new Reply()
                    {
                        User = u,
                        Header = "Reply " + j.ToString() + " for Story " +
                               i.ToString(),
                        Body = "Body " + j.ToString() + " for story " +
                             i.ToString()
                    };
                    replies.Add(r);
                }
            }
        }

        #endregion Methods
    }
}
