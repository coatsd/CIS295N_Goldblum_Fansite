using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DC_Fan_Site_Goldbloom.Controllers;
using DC_Fan_Site_Goldbloom.Models;
using DC_Fan_Site_Goldbloom.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace RepositoryTests
{
	public class StoryControllerTests
	{
		StoryTestRepository storyRepo = new StoryTestRepository();
		ReplyTestRepository replyRepo = new ReplyTestRepository();

		public StoryControllerTests()
        {
            // Note that the constructor for the controllers call for creating
            // 3 test objects in their respective constructors.
        }

        [Fact]
        public void TestConstructor()
        {
			StoriesController storyController = new StoriesController(storyRepo, replyRepo);
			Assert.True(storyController.StoryRepository.Stories.Count == 3);
        }

		[Fact]
		public void TestPostListView()
		{
			StoriesController storyController = new StoriesController(storyRepo, replyRepo);
			Assert.True(storyController.ReplyRepository.Replies.Count == 3);
		}
	}
}
