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
        public int CountryId { get; set; }

        // -------- navigation properties --------
        public Country Country { get; set; } 
        public ICollection<Book> Books { get; set; }
    }
}