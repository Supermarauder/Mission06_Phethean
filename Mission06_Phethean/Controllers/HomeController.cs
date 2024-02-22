using Microsoft.AspNetCore.Mvc;
using Mission06_Phethean.Models;
using SQLitePCL;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_Phethean.Controllers
{
    public class HomeController : Controller
    {
        private AddNewMovieContext _context;
        public HomeController(AddNewMovieContext temp) //Constructor
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
        public IActionResult AddNewMovie()
        {
            ViewBag.Category = _context.Categories
                .ToList();

            return View("AddNewMovie", new AddMovieModel()); 
        }
        [HttpPost]
        public IActionResult AddNewMovie(AddMovieModel response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Category = _context.Categories
                       .ToList();

                return View(response);
            }
        }

        public IActionResult ViewList()
        {
            //link
            var movies = _context.Movies
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id); //goes to look out for one record
            ViewBag.Category = _context.Categories
                   .ToList();
            return View("AddNewMovie", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(AddMovieModel updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("ViewList");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
               .Single(x => x.MovieId == id); //goes to look out for one record

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(AddMovieModel deletedRecord)
        {
            _context.Movies.Remove(deletedRecord);
            _context.SaveChanges();

            return RedirectToAction("ViewList");
        }
    }
}
