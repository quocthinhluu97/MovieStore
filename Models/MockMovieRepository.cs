using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MockMovieRepository : IMovieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Movie> AllMovies =>
            new List<Movie>
            {
                new Movie { MovieId=1, Name="Kungfu Hustle", Category = _categoryRepository.AllCategories.FirstOrDefault(o=>o.Name == "Comedy"),
                Description="Yet another Stephen Chow's movie.",
                Price=19.95M,
                Rating="PG-13",
                IsMovieOfTheWeek=true,
                ImageThumbnailUrl="http://image.phimmoizz.net/film/362/poster.medium.jpg"},

                new Movie { MovieId=2, Name="The Mist", Category= _categoryRepository.AllCategories.FirstOrDefault(o=>o.Name == "Horror"),
                Description="Stephen King's movie.",
                Price=29.5M,
                Rating="R",
                IsMovieOfTheWeek=true,
                ImageThumbnailUrl="http://image.phimmoizz.net/film/2853/poster.medium.jpg"},

                new Movie { MovieId=3, Name="Tokyo Drift", Category = _categoryRepository.AllCategories.FirstOrDefault(o=>o.Name=="Thriller"),
                Description="The best of FnF series.",
                Price=20M,
                Rating="NC-17",
                IsMovieOfTheWeek=true,
                ImageThumbnailUrl="http://image.phimmoizz.net/film/66/poster.medium.jpg"}
            };

        public IEnumerable<Movie> MoviesOfTheWeek { get; }

        public Movie GetMovieById(int movieId)
        {
            return AllMovies.FirstOrDefault(m => m.MovieId == movieId);
        }
    }
}
