using FPTBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Customer> Customer{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            SeedCart(builder);
            SeedCustomer(builder);

            
            
        }
        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
           new Book { Id = 1, Name = "Truyen ma", Price = 20000, Title = "Truyen ma", CartId = 1, CustomerId = 1, Image = "https://radiotruyen.info/upload/cover/thumbnail_wm/Bao-Mong-Truyen-Ma-Kinh-Di.jpg" },
           new Book { Id = 2, Name = "De men phuu luu ki", Price = 22000, Title = "Truyen tranh", CartId = 2, CustomerId = 2, Image = "https://i.ytimg.com/vi/VM03KHkVXuc/maxresdefault.jpg" },
           new Book { Id = 3, Name = "Doraemon", Price = 40000, Title = "Truyen tranh", CartId = 3, CustomerId = 3, Image = "https://m.media-amazon.com/images/M/MV5BYzIzOWQ3NDYtOTFlOC00OGMwLTgwZWItNWI2ZDlmZGEwNGQ3XkEyXkFqcGdeQXVyODAzNzAwOTU@.jpg" },
           new Book { Id = 4, Name = "o long vien", Price = 29000, Title = "Truyen tranh", CartId = 4, CustomerId = 4, Image = "https://1.bp.blogspot.com/-0nneT6gz6EU/YLunEqXZSUI/AAAAAAAAAJE/RNzZLQq9zBUsFXHCHUmZK0eZln87RPWMQCLcBGAsYHQ/w0/5.jpeg" },
           new Book { Id = 5, Name = "It ", Price = 30000, Title = "Sach khoa hoc", CartId = 5, CustomerId = 5, Image = "" }

           );
        }
        private void SeedCart(ModelBuilder builder) 
        {
            builder.Entity<Cart>().HasData(
                new Cart { Id = 1, Name = "Lama1", Price = 20000, Title = "Truyen ma"},
                new Cart { Id = 2, Name = "Lama2", Price = 25000, Title = "Truyen ma" },
                new Cart { Id = 3, Name = "Lama3", Price = 27000, Title = "Sach Khoa hoc" },
                new Cart { Id = 4, Name = "Lama4", Price = 27000, Title = "Sach Khoa hoc" },
                new Cart { Id = 5, Name = "Lama5", Price = 27000, Title = "Sach Khoa hoc" }

                );
        }
        private void SeedCustomer(ModelBuilder builder)
        {
            builder.Entity<Customer>().HasData(
                new Customer { Id = 1, Email = "minhlc@gmail.com", Name = "Nguyen Van Minh", Phone = "0866046616"},
                new Customer { Id = 2, Email = "admin@gmail.com", Name = "Nguyen Van Binh", Phone = "0866046617" },
                new Customer { Id = 3, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" },
                new Customer { Id = 4, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" },
                new Customer { Id = 5, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" }
                );
        }

    }
}
