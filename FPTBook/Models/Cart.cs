using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public float Price { get; set; }

        [Required]
        [Range(1, (100))]
        public int Amount { get; set; }
        
        public ICollection<Book>Book { get; set; }
    }
}
