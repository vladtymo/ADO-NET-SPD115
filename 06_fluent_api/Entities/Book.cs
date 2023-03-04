using _06_fluent_api.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_fluent_api
{
    // -=-=-=-=-=- entity class -=-=-=-=-=-
    public class Book
    {
        public int Number { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public float? Rating { get; set; }
        public int? GenreId { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
        public Genre Genre { get; set; }
    }
}