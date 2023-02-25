namespace _05_intro_to_ef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryDbContext context = new LibraryDbContext();

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
                Console.WriteLine($"[{b.Id}] - {b.Name} {b.Year}");
            }

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
                Name = "Blue Sky",
                Year = 2017,
                Authors = new[] { author }
            });

            // submit changes to database
            context.SaveChanges();

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
        }
    }
}