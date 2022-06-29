using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field cannot be empty!")]
        [MinLength(10, ErrorMessage = "The name length must be longer than 10!")]
        [MaxLength(100, ErrorMessage = "The name length exceed maximum required characters!")]

        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }

    }
}
