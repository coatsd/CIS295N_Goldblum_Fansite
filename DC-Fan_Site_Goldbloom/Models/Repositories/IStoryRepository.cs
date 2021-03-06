﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Fan_Site_Goldbloom.Models
{
    public interface IStoryRepository
	{
		#region Methods

		List<Story> Stories { get; }
		void AddStory(Story story);
		IEnumerable<Story> GetUserStories(string userName);
		IEnumerable<Story> GetStoriesByHeader(string header);
		IEnumerable<Story> GetStoriesByBody(string body);
        void CreateTestData(int cap);
		
		#endregion Methods
	}
}
