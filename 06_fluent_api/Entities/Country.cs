using System.ComponentModel.DataAnnotations;

namespace _06_fluent_api
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Code { get; set; }

        // -------- navigation properties --------
        public ICollection<Author> Authors { get; set; }
    }
}