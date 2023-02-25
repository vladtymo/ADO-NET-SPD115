namespace _05_intro_to_ef
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}