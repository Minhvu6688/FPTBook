using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Book
    {
        
        public int Id { get; set; }
        [MinLength(1)]
        [MaxLength(30)]

        public string Name { get; set; }

        [Range(10,100000)]
        public float Price { get; set; }
        public string Title { get; set; }

        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public Cart Cart { get; set; }
        public Customer Customer { get; set; }
 
    }
}
