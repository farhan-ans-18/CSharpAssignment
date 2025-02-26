using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MoviesList.Models;

namespace MoviesList.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IMovieList movieList;

        public HomeController(IMovieList movieList)
        {
            this.movieList = movieList;
        }

        public IActionResult Index()
        {
            var vm = new MovieVM
            {
                Movies=movieList.GetAll()
            };

            return View(vm);
            
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            movieList.Add(movie);
            return RedirectToAction("Index");
        }

        

       
    }
}
