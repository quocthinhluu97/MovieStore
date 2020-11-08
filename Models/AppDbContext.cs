using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrdersDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Horror", Description = "A horror film is one that seeks to elicit fear in its audience for entertainment purposes. Horror films additionally aim to evoke viewers' nightmares, fears, revulsions and terror of the unknown and macabre. Initially inspired by literature from authors such as Edgar Allan Poe, Bram Stoker, and Mary Shelley, horror has existed as a film genre for more than a century. Horror may also overlap with the fantasy, supernatural fiction, and thriller genres." }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 2, Name = "Comedy", Description = "Comedy Films are make 'em laugh films designed to elicit laughter from the audience. Comedies are light-hearted dramas, crafted to amuse, entertain, and provoke enjoyment. The comedy genre humorously exaggerates the situation, the language, action, and characters" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 3, Name = "Thriller", Description = "Thriller is a genre of fiction, having numerous, often overlapping subgenres. Thrillers are characterized and defined by the moods they elicit, giving viewers heightened feelings of suspense, excitement, surprise, anticipation and anxiety. Successful examples of thrillers are the films of Alfred Hitchcock." }
                );

            // Seed movies
            modelBuilder.Entity<Movie>().HasData(
  new Movie
  {
      MovieId = 1,
      Name = "Kungfu Hustle",
      CategoryId = 2,
      Description = "Yet another Stephen Chow's movie.",
      Price = 19.95M,
      Rating = "PG-13",
      IsMovieOfTheWeek = true,
      ImageThumbnailUrl = "http://image.phimmoizz.net/film/362/poster.medium.jpg"
  }
                );
            modelBuilder.Entity<Movie>().HasData(
                  new Movie
                  {
                      MovieId = 2,
                      Name = "The Mist",
                      CategoryId = 1,
                      Description = "Stephen King's movie.",
                      Price = 29.5M,
                      Rating = "R",
                      IsMovieOfTheWeek = true,
                      ImageThumbnailUrl = "http://image.phimmoizz.net/film/2853/poster.medium.jpg"
                  }
                );
            modelBuilder.Entity<Movie>().HasData(
                  new Movie
                  {
                      MovieId = 3,
                      Name = "Tokyo Drift",
                      CategoryId = 3,
                      Description = "The best of FnF series.",
                      Price = 20M,
                      Rating = "NC-17",
                      IsMovieOfTheWeek = true,
                      ImageThumbnailUrl = "http://image.phimmoizz.net/film/66/poster.medium.jpg"
                  }
                );
        }
    }
}
