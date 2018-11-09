using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DC_Fan_Site_Goldbloom.Models;

namespace DC_Fan_Site_Goldbloom.Controllers
{
    public class SourceController : Controller
    {
        #region Variables and Constructors

        private List<Media> mediaList = new List<Media>();

        public SourceController()
        {
            Media media1 = new Media() { Title = "Jeff Goldblum",
										 Artist = "imdb.com",
                                         Type = "Biography",
										 Link = 
										 "https://www.imdb.com/name/nm0000156/"
										};

            mediaList.Add(media1);
        }

        #endregion Variables and Constructors

        #region Methods that return a View

        public IActionResult Sources()
        {
            return View("Sources", mediaList);
        }

        #endregion Methods that return a view
    }
}
