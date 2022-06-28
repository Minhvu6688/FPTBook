using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(100)]

        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }

        public ICollection<Book> Book { get; set; }
    }
}
