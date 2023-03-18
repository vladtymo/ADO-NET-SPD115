using Microsoft.EntityFrameworkCore;

namespace _06_fluent_api
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDbContext context = new LibraryDbContext();

            #region Get Data
            // ------------- show all countries
            Console.WriteLine("------------ Countries ------------");
            foreach (var b in context.Countries)
            {
                Console.WriteLine($"[{b.Id}] - {b.Name}");
            }

            // ------------- show books by year
            Console.WriteLine("------------ Books from 2010 ------------");
            var query = context.Books.Where(x => x.Year >= 2010)
                                     .OrderByDescending(x => x.Year);

            foreach (var b in query)
            {
                Console.WriteLine($"[{b.Number}] - {b.Title} {b.Year}");
            }
            #endregion

            #region Insert Data
            // ------------- add new items
            var author = new Author()
            {
                Name = "Ivan",
                Surname = "Franko",
                CountryId = 1
            };
            context.Authors.Add(author);

            context.Books.Add(new Book()
            {
                Title = "Blue Sky",
                Year = 2017,
                Authors = new[] { author }
            });

            // submit changes to database
            context.SaveChanges();
            #endregion

            #region Find, Update and Delete Data
            // ------------- find item
            Console.Write("Enter book ID to find: ");
            int id = int.Parse(Console.ReadLine());

            var book = context.Books.Find(id);
            if (book == null) Console.WriteLine("Not found!");

            // ------------- edit item
            if (book != null)
            {
                book.Year -= 5;
                context.Books.Update(book);
                context.SaveChanges();
                Console.WriteLine("Book was updated!");
            }

            // ------------- delete item
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                Console.WriteLine("Book was deleted!");
            }
            #endregion

            #region Include Navigation Properties
            // ------------- show all books with included genre -------------
            // eager loading - невідкладне завантаження зв'язаних даних
            //  .Include(prop) - виконує команду LEFT JOIN
            var allBooks = context.Books.Include(x => x.Genre);

            Console.WriteLine("------------ All Books ------------");
            foreach (var b in allBooks)
            {
                Console.WriteLine($"[{b.Number}] - {b.Title} {b.Year} {b.Genre?.Name ?? "not loaded"}");
            }

            Console.Write("Enter genre: ");
            string genreName = Console.ReadLine();

            // eager loading
            //var genre = context.Genres.Include(x => x.Books).FirstOrDefault(x => x.Name == genreName);
            var genre = context.Genres.FirstOrDefault(x => x.Name == genreName);

            if (genre == null)
                Console.WriteLine("Name was not found!");
            else
            {
                // explicit loading - явне завантаження зв'язаних даних
                //  .Collection(name) - завантаження зв'язаних колекцій
                //  .Reference(name) - завантаження зв'язаних властивостей
                context.Entry(genre).Collection(x => x.Books).Load();

                Console.WriteLine("\tAll books with this genre:");
                foreach (var b in genre.Books)
                {
                    Console.WriteLine(b.Title);
                }
            }

        }
    }
}