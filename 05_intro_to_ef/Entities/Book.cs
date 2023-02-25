namespace _05_intro_to_ef
{
    // -=-=-=-=-=- entity class -=-=-=-=-=-
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}