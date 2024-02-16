using Microsoft.AspNetCore.Mvc;
using Mission06_Phethean.Models;
using SQLitePCL;
using System.Diagnostics;

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
            return View(); 
        }
        [HttpPost]
        public IActionResult AddNewMovie(AddMovieModel response)
        {
            _context.NewMovie.Add(response);
            _context.SaveChanges();
            return View("Confirmation", response);
        }
    }
}
