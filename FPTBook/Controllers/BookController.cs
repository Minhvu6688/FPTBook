using FPTBook.Data;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult BookDetail(int id=1)
        {
            var book = context.Book
               .FirstOrDefault(m => m.Id == id)
           ;
            return View(book);

        }
    }
}
