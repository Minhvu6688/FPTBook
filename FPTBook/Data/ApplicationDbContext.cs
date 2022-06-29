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
        public DbSet<User> Customer{ get; set; }

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
           new Book { Id = 1, Name = "Truyen ma", Price = 20000, Title = "Truyen ma", CartId = 1, CustomerId = 1,  },
           new Book { Id = 2, Name = "De men phuu luu ki", Price = 22000, Title = "Truyen tranh", CartId = 2, CustomerId = 2,  },
           new Book { Id = 3, Name = "Doraemon", Price = 40000, Title = "Truyen tranh", CartId = 3, CustomerId = 3, },
           new Book { Id = 4, Name = "o long vien", Price = 29000, Title = "Truyen tranh", CartId = 4, CustomerId = 4,  },
           new Book { Id = 5, Name = "It ", Price = 30000, Title = "Sach khoa hoc", CartId = 5, CustomerId = 5, }
           );
        }
        private void SeedCart(ModelBuilder builder) 
        {
            builder.Entity<Cart>().HasData(
                new Cart { Id = 1,  Price = 20000, Amount = 1},
                new Cart { Id = 2, Price = 21000, Amount = 2 },
                new Cart { Id = 3, Price = 22000, Amount = 3 },
                new Cart { Id = 4, Price = 23000, Amount = 4 },
                new Cart { Id = 5, Price = 24000, Amount = 5 }

                );
        }
        private void SeedCustomer(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { Id = 1, Email = "minhlc@gmail.com", Name = "Nguyen Van Minh", Phone = "0866046616"},
                new User { Id = 2, Email = "admin@gmail.com", Name = "Nguyen Van Binh", Phone = "0866046617" },
                new User { Id = 3, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" },
                new User { Id = 4, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" },
                new User { Id = 5, Email = "custumer@gmail.com", Name = "Nguyen Thi Linh", Phone = "0866046618" }
                );
        }

    }
}
