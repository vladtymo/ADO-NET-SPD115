﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_fluent_api
{
    // -=-=-=-=-=- entity class -=-=-=-=-=-
    [Table("Products")]
    public class Book
    {
        // Primary key naming: Id/id/ID EntityName+Id (BookId)

        [Key]               // set primary key
        public int Number { get; set; }

        [Required]          // set not null
        [MaxLength(200)]    // set nvarchar(200)
        public string? Name { get; set; }

        [Column("PublishYear")]
        public int Year { get; set; }
        public float? Rating { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}