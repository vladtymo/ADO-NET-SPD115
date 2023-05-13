using _06_fluent_api;
using Microsoft.EntityFrameworkCore;

namespace _07_async_ef
{
    public class BookManager
    {
        private LibraryDbContext context;

        public BookManager()
        {
            context = new LibraryDbContext();
        }

        // async - mark method as asynchronous, allows you to use await keyword
        // await - do an operation asynchronouslly
        public async Task<List<Book>> GetAll()
        {
            return await context.Books.ToListAsync();
        }
        public async Task<Book?> Get(int id)
        {
            return await context.Books.FindAsync(id);
        }

        public async Task Create(Book book)
        {
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();
        }
        public async Task Edit(Book book)
        {
            context.Books.Update(book);
            await context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var book = await Get(id);

            if (book == null) return;

            context.Books.Remove(book);
            await context.SaveChangesAsync();
        }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            BookManager manager = new BookManager();

            foreach (var b in await manager.GetAll())
            {
                Console.WriteLine($"[{b.Number}] - {b.Title} {b.Year}");
            } 
        }
    }
}