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
        public DbSet<Customer> Customer { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            
        }
        private void SeedBook(ModelBuilder builder)
        {
                 builder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Truyen ma", Price = 20000, Title = "Truyen ma" },
                new Book { Id = 2, Name = "De men phuu luu ki", Price = 22000, Title = "Truyen tranh" },
                new Book { Id = 3, Name = "Doraemon", Price = 40000, Title = "Truyen tranh" },
                new Book { Id = 4, Name = "o long vien", Price = 29000, Title = "Truyen tranh" },
                new Book { Id = 5, Name = "It ", Price = 30000, Title = "Sach khoa hoc" }

                );
                //builder.Entity<Book>().ToTable("Cart");


        }

    }
}
