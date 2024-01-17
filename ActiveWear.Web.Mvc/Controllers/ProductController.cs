using ActiveWear.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace ActiveWear.Web.Mvc.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var options = new RestClientOptions("https://localhost:5000/api");
            
            var client = new RestClient(options);

            var request = new RestRequest($"products/{id}", Method.Get);

            var product = await client.GetAsync<ProductViewModel>(request);

            return View(product);
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
