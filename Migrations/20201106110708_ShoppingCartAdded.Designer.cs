﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieStore.Models;

namespace MovieStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201106110708_ShoppingCartAdded")]
    partial class ShoppingCartAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "A horror film is one that seeks to elicit fear in its audience for entertainment purposes. Horror films additionally aim to evoke viewers' nightmares, fears, revulsions and terror of the unknown and macabre. Initially inspired by literature from authors such as Edgar Allan Poe, Bram Stoker, and Mary Shelley, horror has existed as a film genre for more than a century. Horror may also overlap with the fantasy, supernatural fiction, and thriller genres.",
                            Name = "Horror"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Comedy Films are make 'em laugh films designed to elicit laughter from the audience. Comedies are light-hearted dramas, crafted to amuse, entertain, and provoke enjoyment. The comedy genre humorously exaggerates the situation, the language, action, and characters",
                            Name = "Comedy"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Thriller is a genre of fiction, having numerous, often overlapping subgenres. Thrillers are characterized and defined by the moods they elicit, giving viewers heightened feelings of suspense, excitement, surprise, anticipation and anxiety. Successful examples of thrillers are the films of Alfred Hitchcock.",
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("MovieStore.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMovieOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Rating")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Description = "Yet another Stephen Chow's movie.",
                            ImageThumbnailUrl = "http://image.phimmoizz.net/film/362/poster.medium.jpg",
                            IsMovieOfTheWeek = true,
                            Name = "Kungfu Hustle",
                            Price = 19.95m,
                            Rating = "PG-13"
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 1,
                            Description = "Stephen King's movie.",
                            ImageThumbnailUrl = "http://image.phimmoizz.net/film/2853/poster.medium.jpg",
                            IsMovieOfTheWeek = true,
                            Name = "The Mist",
                            Price = 29.5m,
                            Rating = "R"
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 3,
                            Description = "The best of FnF series.",
                            ImageThumbnailUrl = "http://image.phimmoizz.net/film/66/poster.medium.jpg",
                            IsMovieOfTheWeek = true,
                            Name = "Tokyo Drift",
                            Price = 20m,
                            Rating = "NC-17"
                        });
                });

            modelBuilder.Entity("MovieStore.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("MovieId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("MovieStore.Models.Movie", b =>
                {
                    b.HasOne("MovieStore.Models.Category", "Category")
                        .WithMany("Movies")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieStore.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("MovieStore.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");
                });
#pragma warning restore 612, 618
        }
    }
}
