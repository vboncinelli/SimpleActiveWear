using Microsoft.AspNetCore.Mvc;

namespace ActiveWear.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            // 1. recuperare dalle api il prodotto cercato
            // 2. passarlo alla vista.

            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            // 1. recuperare dalle api la lista dei prodotti
            // 2. passarla alla vista.
            
            return View();
        }
    }
}
