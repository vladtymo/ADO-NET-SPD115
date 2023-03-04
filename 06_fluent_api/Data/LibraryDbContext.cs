using _06_fluent_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace _06_fluent_api
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
        {
            //Database.EnsureDeleted();
            // create database if not exists
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ------- entity configurations -------
            modelBuilder.Entity<Book>().HasKey(x => x.Number);  // set primary key
            modelBuilder.Entity<Book>().Property(x => x.Name)
                                            .HasMaxLength(200)  // set nvarchar(200)
                                            .IsRequired();      // set not null
            modelBuilder.Entity<Book>().ToTable("Products");    // set table and column name
            modelBuilder.Entity<Book>().Property(x => x.Year).HasColumnName("PublishYear");

            modelBuilder.Entity<Country>().Property(x => x.Name).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Author>().Ignore(x => x.FullName);

            // ------- configure relationships
            // *...* - many to many
            modelBuilder.Entity<Book>().HasMany(x => x.Authors).WithMany(x => x.Books);
            // 1...* - one to many
            modelBuilder.Entity<Author>()
                .HasOne(x => x.Country)
                .WithMany(x => x.Authors)
                .HasForeignKey(x => x.CountryId);
            // 1/0...* - one to many
            modelBuilder.Entity<Book>()
                .HasOne(x => x.Genre)
                .WithMany(x => x.Books)
                .HasForeignKey(x => x.GenreId)
                .IsRequired(false);

            // ------- seed data -------
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Italy"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "Spain"}
            });
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Mystery"},
                new Genre() { Id = 2, Name = "Romance"},
                new Genre() { Id = 3, Name = "Fiction"},
                new Genre() { Id = 4, Name = "Novel" }
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
        public DbSet<Genre> Genres { get; set; }
    }
}