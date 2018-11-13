using System;
using System.Collections.Generic;
using System.Text;
using DC_Fan_Site_Goldbloom.Controllers;
using DC_Fan_Site_Goldbloom.Models;
using Xunit;
namespace RepositoryTests
{
	public class StoryControllerTests
	{
        public StoryControllerTests()
        {
            StoryTestRepository storyRepo = new StoryTestRepository();

            StoriesController storyController = new StoriesController(storyRepo);
        }

        [Fact]
        public void TestTests()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestController()
        {

        }
	}
}
