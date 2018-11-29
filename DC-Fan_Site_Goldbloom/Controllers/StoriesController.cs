using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DC_Fan_Site_Goldbloom.Models;
using DC_Fan_Site_Goldbloom.Models.Repositories;

namespace DC_Fan_Site_Goldbloom.Controllers
{
    public class StoriesController : Controller
    {
		#region Variables and Contructors

		IStoryRepository storyRepository;
		IReplyRepository replyRepository;

		public StoriesController(IStoryRepository storyRepo,
								 IReplyRepository replyRepo)
        {
            storyRepository = storyRepo;
			replyRepository = replyRepo;

            storyRepository.CreateTestData(3);
            replyRepository.CreateTestData(3);

            // Sort the stories by the first letter of the Header Property
			// in each story.
            // storyRepo.Stories.Sort((s1, s2) => 
			//							 s1.Header.Substring(0).CompareTo(
			//							 s2.Header.Substring(0)));
        }

        #endregion Variables and Constructors

		public IStoryRepository StoryRepository { get { return storyRepository; } }

		public IReplyRepository ReplyRepository { get { return replyRepository; } }

        #region Methods that return a View

        [HttpGet]
        public IActionResult StoryForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostConfirm([Bind("Header, Body")] Story story)
        {
			if (ModelState.IsValid)
			{
				storyRepository.AddStory(story);
				return View("PostConfirm", story);
			}
			return View("StoryForm");
        }

        public IActionResult PostList()
        {
			ViewBag.PostCount = storyRepository.Stories.Count;
            ViewBag.Replies = replyRepository.Replies;
            return View("PostList", storyRepository.Stories);
        }

		[HttpPost]
		public IActionResult SearchPostListHeader(string header)
		{
			ViewBag.PostCount = storyRepository.Stories.Count;
			ViewBag.Replies = replyRepository.Replies;
			return View("PostList", storyRepository.GetStoriesByHeader(header).ToList());
		}

		[HttpPost]
		public IActionResult SearchPostListBody(string body)
		{
			ViewBag.PostCount = storyRepository.Stories.Count;
			ViewBag.Replies = replyRepository.Replies;
			return View("PostList", storyRepository.GetStoriesByBody(body).ToList());
		}

		public IActionResult ReplyForm(int storyID)
        {
			Reply reply = new Reply { StoryID = storyID };
			List<Story> stories = storyRepository.Stories.ToList();
			for (int i = 0; i < stories.Count; i++)
			{
				if (stories[i].StoryID == storyID)
				{
					ViewBag.StoryHeader = stories[i].Header;
					break;
				}
			}
            return View("ReplyForm", reply);
        }

        [HttpPost]
        public IActionResult ReplyView([Bind("StoryID, Header, Body")] Reply reply, int storyID)
        {
			if (ModelState.IsValid)
			{
				replyRepository.AddReply(reply);
				return View("PostConfirm", reply);
			}
			return ReplyForm(storyID);
        }

        #endregion Methods that return a View
    }
}