using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_fluent_api.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // -------- navigation properties --------
        public ICollection<Book> Books { get; set; }
    }
}
