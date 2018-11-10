using System;
using Xunit;
using DC_Fan_Site_Goldbloom.Controllers;
using DC_Fan_Site_Goldbloom.Models;

namespace RepositoryTests
{
    public class StoryRepoTests
    {
		StoryTestRepository testRepo = new StoryTestRepository();

		public StoryRepoTests()
		{
			
		}

        [Fact]
        public void TestTesting()
        {
			Assert.True(true);
        }

		[Fact]
		public void TestCreateStories()
		{
			testRepo.CreateTestData(3);
			Assert.True(testRepo.Stories.Count == 3);
		}

        [Fact]
        public void TestGetUserStories()
        {
            testRepo.CreateTestData(3);
            Assert.True(testRepo.GetUserStories("User 0").Count == 1);
        }
    }
}
