using Microsoft.AspNetCore.Mvc;
using Mission6_HaydenEnloe.Models;
using System.Diagnostics;

namespace Mission6_HaydenEnloe.Controllers // overarching name of the project
{
    public class HomeController : Controller // public class, inherits from the Controller class
    {
        private EnterMovieContext _context;
        public HomeController(EnterMovieContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(EnterMovie response)
        {
            _context.Applications.Add(response); // Add record to the database
            _context.SaveChanges(); 

            return View("Confirmation", response); 
        }

    }
}
