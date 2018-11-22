using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models.Repositories
{
    public interface IReplyRepository
	{
        List<Reply> Replies { get; }

        #region Methods

        void AddReply(Reply reply);
        IEnumerable<Reply> GetUserReplies(string userID);

        #endregion Methods
    }
}
