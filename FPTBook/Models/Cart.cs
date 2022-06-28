using System.Collections.Generic;

namespace FPTBook.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Title { get; set; }
        
        public ICollection<Book>Book { get; set; }
    }
}
