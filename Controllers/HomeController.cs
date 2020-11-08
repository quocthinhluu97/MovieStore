using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.Models;
using MovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public HomeController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MoviesOfTheWeek = _movieRepository.MoviesOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
