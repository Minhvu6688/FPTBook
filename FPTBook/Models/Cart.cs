using FPTBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FPTBook.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public float Price { get; set; }

        public DateTime Order_Date { get; set; }

        [Required]
        [Range(1, (100))]
        public int Amount { get; set; }
        
        public Book Book { get; set; }
    }
}
