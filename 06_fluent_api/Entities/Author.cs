using System.ComponentModel.DataAnnotations.Schema;

namespace _06_fluent_api
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public string FullName => $"{Name} {Surname}";

        // -------- navigation properties --------
        public Country Country { get; set; } 
        public ICollection<Book> Books { get; set; }
    }
}