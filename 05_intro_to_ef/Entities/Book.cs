using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _05_intro_to_ef
{
    // -=-=-=-=-=- entity class -=-=-=-=-=-
    [Table("Products")]
    public class Book
    {
        // Primary key naming: Id/id/ID EntityName+Id (BookId)

        [Key]               // set primary key
        public int Number { get; set; }

        [Required]          // set not null
        [MaxLength(100)]    // set nvarchar(100)
        public string? Name { get; set; }

        [Column("PublishYear")]
        public int Year { get; set; }
        public float? Rating { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}