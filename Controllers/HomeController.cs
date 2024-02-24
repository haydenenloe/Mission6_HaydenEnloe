using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View(new EnterMovie());
        }

        [HttpPost]
        public IActionResult Movies(EnterMovie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to the database
                _context.SaveChanges(); 

                return View("Confirmation", response); 
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.CategoryName)
                    .ToList();

                return View(response);
            }
        }

        public IActionResult MovieList ()
        {
            // linq: the way to do SQL in C#
            // x is the EnterMovie object
            // _context is an instance of the EnterMovieContext class

            var new_movie = _context.Movies.Include("Category")
                .OrderBy(x => x.Director).ToList();

            // if you are displaying a dynamic page, usually you would pass something in
            // if it is a static page then you are fine to leave the () empty
            return View(new_movie);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.CategoryName)
                .ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(EnterMovie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x =>x.MovieId == id);

            //ViewBag.Categories = _context.Categories
            //    .OrderBy(x => x.CategoryName)
            //    .ToList();

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(EnterMovie deleteMovie)
        {
            _context.Movies.Remove(deleteMovie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
