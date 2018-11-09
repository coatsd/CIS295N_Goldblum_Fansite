using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DC_Fan_Site_Goldbloom.Models;

namespace DC_Fan_Site_Goldbloom.Controllers
{
    public class HomeController : Controller
    {
        #region variables and constructors

        #endregion variables and constructors

        #region Methods that return a View

        public IActionResult Index()
        {
            ViewBag.Arbitrary = "Arbitrary Viewbag Stuff";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Description = "This is the description of the website, AKA " +
                "ViewBag Stuff";

            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Memes()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion Methods that return a View
    }
}
