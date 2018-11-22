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
    public class SourceController : Controller
    {
        #region Variables and Constructors

        IMediaRepository mediaRepository;
        IBookRepository bookRepository;

        public SourceController(IMediaRepository mediaRepo,
                                IBookRepository bookRepo)
        {
            mediaRepository = mediaRepo;
            bookRepository = bookRepo;
        }

        #endregion Variables and Constructors

        #region Methods that return a View

        public IActionResult Media()
        {
            return View("Media", mediaRepository.Medias);
        }

        public IActionResult Books()
        {
            return View("Books", bookRepository.Books);
        }

        #endregion Methods that return a view
    }
}
