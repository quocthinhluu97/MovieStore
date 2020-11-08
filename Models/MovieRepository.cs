using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _appDbContext;

        public MovieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Movie> AllMovies
        {
            get
            {
                return _appDbContext.Movies.Include(m => m.Category);
            }
        }

        public IEnumerable<Movie> MoviesOfTheWeek
        {
            get
            {
                return _appDbContext.Movies.Include(m => m.Category).Where(m => m.IsMovieOfTheWeek);
            }
        }

        public Movie GetMovieById(int movieId)
        {
            return _appDbContext.Movies.FirstOrDefault(m => m.MovieId == movieId);
        }
    }
}
