using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using MovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public MovieController(IMovieRepository movieRepository, ICategoryRepository categoryRepository)
        {
            _movieRepository = movieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List(string category)
        {
            IEnumerable<Movie> movies;
            string currentCategory;

            if (String.IsNullOrEmpty(category))
            {
                movies = _movieRepository.AllMovies.OrderBy(m => m.MovieId);
                currentCategory = "All";
            }
            else
            {
                movies = _movieRepository.AllMovies.Where(m => m.Category.Name == category).OrderBy(m => m.MovieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.Name == category)?.Name;
            }

            return View(new MovieListViewModel
            {
                Movies = movies,
                CurrentCategory = currentCategory
            }) ; 
        }

        public IActionResult Detail(int id)
        {
            var movie = _movieRepository.GetMovieById(id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}
