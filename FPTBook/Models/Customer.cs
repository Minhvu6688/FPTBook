using System.Collections.Generic;

namespace FPTBook.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
