using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieStore.Migrations
{
    public partial class AddDataSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 1, "A horror film is one that seeks to elicit fear in its audience for entertainment purposes. Horror films additionally aim to evoke viewers' nightmares, fears, revulsions and terror of the unknown and macabre. Initially inspired by literature from authors such as Edgar Allan Poe, Bram Stoker, and Mary Shelley, horror has existed as a film genre for more than a century. Horror may also overlap with the fantasy, supernatural fiction, and thriller genres.", "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 2, "Comedy Films are make 'em laugh films designed to elicit laughter from the audience. Comedies are light-hearted dramas, crafted to amuse, entertain, and provoke enjoyment. The comedy genre humorously exaggerates the situation, the language, action, and characters", "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[] { 3, "Thriller is a genre of fiction, having numerous, often overlapping subgenres. Thrillers are characterized and defined by the moods they elicit, giving viewers heightened feelings of suspense, excitement, surprise, anticipation and anxiety. Successful examples of thrillers are the films of Alfred Hitchcock.", "Thriller" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CategoryId", "Description", "ImageThumbnailUrl", "IsMovieOfTheWeek", "Name", "Price", "Rating" },
                values: new object[] { 2, 1, "Stephen King's movie.", "http://image.phimmoizz.net/film/2853/poster.medium.jpg", true, "The Mist", 29.5m, "R" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CategoryId", "Description", "ImageThumbnailUrl", "IsMovieOfTheWeek", "Name", "Price", "Rating" },
                values: new object[] { 1, 2, "Yet another Stephen Chow's movie.", "http://image.phimmoizz.net/film/362/poster.medium.jpg", true, "Kungfu Hustle", 19.95m, "PG-13" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CategoryId", "Description", "ImageThumbnailUrl", "IsMovieOfTheWeek", "Name", "Price", "Rating" },
                values: new object[] { 3, 3, "The best of FnF series.", "http://image.phimmoizz.net/film/66/poster.medium.jpg", true, "Tokyo Drift", 20m, "NC-17" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
