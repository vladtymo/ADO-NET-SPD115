using System.ComponentModel.DataAnnotations.Schema;

namespace _05_intro_to_ef
{
    // ----------- Relationships -----------
    // 1...* - author has one country, country has many authors
    // *...* - author has many books, book has many authors
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        // Foreign key naming: RelatedEntityName+LelatedEntityPK
        [ForeignKey("Country")] // set foreign key
        public int CountryId { get; set; }

        [NotMapped] // ignore
        public string FullName => $"{Name} {Surname}";

        // -------- navigation properties --------
        [ForeignKey("CountryId")]
        public Country Country { get; set; } 
        public ICollection<Book> Books { get; set; }
    }
}