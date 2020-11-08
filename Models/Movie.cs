using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rating { get; set; }
        public decimal Price { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsMovieOfTheWeek { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
