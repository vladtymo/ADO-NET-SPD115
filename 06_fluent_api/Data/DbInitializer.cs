using _06_fluent_api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _06_fluent_api.Data
{
    static public class DbInitializer
    {
        public static void SeedCountries(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "Italy"},
                new Country() { Id = 3, Name = "France"},
                new Country() { Id = 4, Name = "Spain"}
            });
        }
        public static void SeedGenres(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() { Id = 1, Name = "Mystery"},
                new Genre() { Id = 2, Name = "Romance"},
                new Genre() { Id = 3, Name = "Fiction"},
                new Genre() { Id = 4, Name = "Novel" }
            });
        }
        public static void SeedBooks(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(new[]
            {
                new Book() { Number = 1, Title = "Da Vinci Code,The", Year = 2005, Rating = 9.1F, GenreId = 4 },
                new Book() { Number = 2, Title = "Angels and Demons", Year = 2015, Rating = 5.6F, GenreId = 1 },
                new Book() { Number = 3, Title = "Harry Potter and the Goblet of Fire", Year = 1997, Rating = 7.1F, GenreId = 2 },
                new Book() { Number = 4, Title = "Fifty Shades of Grey", Year = 2010, Rating = 9.8F, GenreId = 2 },
                new Book() { Number = 5, Title = "Twilight", Year = 2022, Rating = 6.7F, GenreId = 1 },
            });
        }
    }
}
