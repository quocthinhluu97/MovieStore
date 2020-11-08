using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, Name="Horror", Description="A horror film is one that seeks to elicit fear in its audience for entertainment purposes. Horror films additionally aim to evoke viewers' nightmares, fears, revulsions and terror of the unknown and macabre. Initially inspired by literature from authors such as Edgar Allan Poe, Bram Stoker, and Mary Shelley, horror has existed as a film genre for more than a century. Horror may also overlap with the fantasy, supernatural fiction, and thriller genres."},
                new Category{CategoryId=2, Name="Comedy", Description="Comedy Films are make 'em laugh films designed to elicit laughter from the audience. Comedies are light-hearted dramas, crafted to amuse, entertain, and provoke enjoyment. The comedy genre humorously exaggerates the situation, the language, action, and characters"},
                new Category{CategoryId=3, Name="Thriller", Description="Thriller is a genre of fiction, having numerous, often overlapping subgenres. Thrillers are characterized and defined by the moods they elicit, giving viewers heightened feelings of suspense, excitement, surprise, anticipation and anxiety. Successful examples of thrillers are the films of Alfred Hitchcock."}
            };
    }
}
