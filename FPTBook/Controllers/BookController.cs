using FPTBook.Data;
using FPTBook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FPTBook.Controllers
{
    public class BookController : Controller
    {
        protected readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Book.ToList());
            
        }
        public IActionResult BookDetail(int? id)
        {
            if (id == null)
                return NotFound();
            var Book = context.Book
                .Include(e => e.Cart)
                .Include(e => e.Customer)
                .FirstOrDefault(m => m.Id == id);
            return View(Book);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();

            }
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Book.Add(book);
                context.SaveChanges();
                return RedirectToAction("Book");

            }
            return View(book);
        }
        public IActionResult Add()
        {

            var cart = context.Cart.ToList();
            var customer = context.Customer.ToList();
            ViewBag.Cart = cart;
            ViewBag.Customer = customer;
            return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Book.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            var author = context.Cart.ToList();
            var customer = context.Customer.ToList();
            ViewBag.Author = author;
            ViewBag.Customer = customer;
            return View(book);
        }


        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Book.Update(book);
                context.SaveChanges();
                return RedirectToAction("ViewBook");
            }
            return View(book);
        }

    }





}

