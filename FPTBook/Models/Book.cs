using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [MinLength(1)]
        [MaxLength(30)]

        public string Name { get; set; }

        [Range(10,1000)]
        public double Price { get; set; }
        public string Title { get; set; }
    }
}
