using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> MoviesOfTheWeek { get; set; }
    }
}
