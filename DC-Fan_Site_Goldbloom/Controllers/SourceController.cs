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
        private List<Book> bookList = new List<Book>();

        public SourceController()
        {
            Media media1 = new Media() { Title = "Jeff Goldblum",
										 Artist = "imdb.com",
                                         Type = "Biography",
										 Link = 
										 "https://www.imdb.com/name/nm0000156/"
										};

            mediaList.Add(media1);

            Book book1 = new Book() { Title = "Do I Hate Being Right All the Time",
                                      Author = "Belly Kids", Genre = "Activity Book",
                                      Publisher = "Belly Kids", PubDate = "2/17/2017"
                                      Link = "https://www.amazon.com/gp/search?index=books&linkCode=qs&keywords=9780995578012"
                                    };

            bookList.Add(book1);
        }

        #endregion Variables and Constructors

        #region Methods that return a View

        public IActionResult Media()
        {
            return View("Media", mediaList);
        }

        #endregion Methods that return a view
    }
}
