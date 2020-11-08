using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using MovieStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IMovieRepository movieRepository, ShoppingCart shoppingCart)
        {
            _movieRepository = movieRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCarViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCarViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int movieId)
        {
            var selectedMovie = _movieRepository.AllMovies.FirstOrDefault(m => m.MovieId == movieId);

            if (selectedMovie != null)
            {
                _shoppingCart.AddToCart(selectedMovie, 1);
            }
            return RedirectToAction("Index");
        }
        public RedirectToActionResult RemoveFromShoppingCart(int movieId)
        {
            var selectedMovie = _movieRepository.AllMovies.FirstOrDefault(m => m.MovieId == movieId);

            if (selectedMovie != null)
            {
                _shoppingCart.RemoveFromCart(selectedMovie);
            }
            return RedirectToAction("Index");
        }
    }
}
