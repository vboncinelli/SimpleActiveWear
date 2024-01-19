using ActiveWear.Web.Mvc.Models;
using ActiveWear.Web.Mvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace ActiveWear.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IClient _client;

        public ProductController(IClient client)
        {
            this._client = client;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            //TODO: gestire eventuali errori con try catch

            var product = await this._client.FindProductAsync(id);

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //TODO: gestire eventuali errori con try catch

            var products = await this._client.GetAllProductsAsync();

            return View("List", products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var newProduct = await this._client.AddProductAsync(model);

            return RedirectToAction("Index");
        }
    }
}
