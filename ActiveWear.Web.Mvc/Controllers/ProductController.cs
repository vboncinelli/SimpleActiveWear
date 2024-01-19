using ActiveWear.Web.Mvc.Models;
using ActiveWear.Web.Mvc.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

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
    }
}
