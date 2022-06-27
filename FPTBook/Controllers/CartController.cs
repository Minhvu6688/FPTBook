using FPTBook.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FPTBook.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationDbContext context;

        public CartController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Cart.ToList());
        }

        //ti huong dan t dung bootstrap nhe cek
    }
}
