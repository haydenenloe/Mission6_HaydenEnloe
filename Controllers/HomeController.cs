using Microsoft.AspNetCore.Mvc;
using Mission6_HaydenEnloe.Models;
using System.Diagnostics;

// a user sends a request
// that request goes to the homeController
// an instance of this controller is created. and the controller then takes over to process the request
// when  an instance of the contorller is created, the contructor is called, and then initializes the database contexts

namespace Mission6_HaydenEnloe.Controllers // overarching name of the project
{
    public class HomeController : Controller // public class, inherits from the Controller class
    {
        private EnterMovieContext _context;
        public HomeController(EnterMovieContext temp) // Constructor
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

        public IActionResult MovieList ()
        {
            return View();
        }
    }
}
