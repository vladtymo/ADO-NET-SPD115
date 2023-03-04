using Microsoft.EntityFrameworkCore;

namespace _06_fluent_api
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
            Database.EnsureDeleted();
            // create database if not exists
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ------- seed data -------
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Italy"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "Spain"}
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SPD115_LibraryDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        // -=-=-=-=-=- data collections (tables) -=-=-=-=-=-
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}