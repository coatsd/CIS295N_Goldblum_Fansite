using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models
{
    public interface IStoryRepository
	{
		List<Story> Stories { get; }

		#region Methods

		void AddStory(Story story);
		List<Story> GetUserStories(string userID);
		
		#endregion Methods
	}
}
