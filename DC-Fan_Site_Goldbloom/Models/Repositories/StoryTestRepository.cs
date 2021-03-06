﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DC_Fan_Site_Goldbloom.Models
{
    public class StoryTestRepository : IStoryRepository
    {
		private List<Story> stories = new List<Story>();

		/// <summary>
		/// This attribute retrieves all the stories that currently reside in 
		/// the "StoryTestRepository" object's Story list.
		/// </summary>
		public List<Story> Stories { get { return stories; } }

		/// <summary>
		/// This Method adds a Story to the Story List stored in the 
		/// Repository.
		/// </summary>
		/// <param name="story"></param>
		public void AddStory(Story story) => stories.Add(story);

		/// <summary>
		/// This method takes a User parameter and returns story objects that
		/// have that user as their User Attribute. This implies that the user
		/// associated with it created the post.
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		public IEnumerable<Story> GetUserStories(string userName)
		{
			List<Story> userStories = new List<Story>();
			stories.ForEach(s =>
			{
				if (s.User.Username == userName)
				{
					userStories.Add(s);
				}
			});

			return userStories;
		}

		public IEnumerable<Story> GetStoriesByHeader(string header)
		{
			List<Story> stories = new List<Story>();
			stories.ForEach(s =>
			{
				if (s.Header == header)
				{
					stories.Add(s);
				}
			});

			return stories;
		}

		public IEnumerable<Story> GetStoriesByBody(string body)
		{
			List<Story> stories = new List<Story>();
			stories.ForEach(s =>
			{
				if (s.Body == body)
				{
					stories.Add(s);
				}
			});

			return stories;
		}

		/// <summary>
		/// This method takes an integer as a parameter, and returns a Story
		/// Object List containing the same number of Stories as the passed 
		/// parameter. Each object has a User and two Reply objects.
		/// </summary>
		/// <param name="cap"></param>
		/// <returns></returns>
		public void CreateTestData(int cap)
		{
			for (int i = 0; i < cap; i++)
			{
				User u = new User() { Username = "User " + i.ToString() };

				Story s = new Story() { StoryID = i,
                                        Header = "Header for Story " + i.ToString(),
										Body = "Body for story " + i.ToString(),
										User = u };

				stories.Add(s);
			}
		}
    }
}
