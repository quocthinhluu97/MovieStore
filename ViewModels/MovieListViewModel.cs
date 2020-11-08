using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
