﻿using System.ComponentModel.DataAnnotations;

namespace _06_fluent_api
{
    public class Country
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}