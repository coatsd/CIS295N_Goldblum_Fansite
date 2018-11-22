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
        public IActionResult PostConfirm(string head, string body)
        {
            Story story = new Story { Header = head, Body = body };
            storyRepository.AddStory(story);
            return View("PostConfirm", story);
        }

        public IActionResult PostList()
        {
			ViewBag.PostCount = storyRepository.Stories.Count;
            return View("PostList", storyRepository.Stories);
        }

        public IActionResult ReplyForm()
        {
            return View("ReplyForm");
        }

        [HttpPost]
        public IActionResult ReplyView(string head, string body)
        {
            Reply reply = new Reply { Header = head, Body = body };
			replyRepository.AddReply(reply);
            return View("PostConfirm", reply);
        }

        #endregion Methods that return a View
    }
}