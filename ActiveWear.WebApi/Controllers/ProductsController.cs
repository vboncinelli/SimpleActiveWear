using ActiveWear.Core.Interfaces;
using ActiveWear.WebApi.Mappers;
using ActiveWear.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ActiveWear.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseApiController
    {
        private readonly IShopRepository _shopRepository;

        public ProductsController(IShopRepository shopRepository)
        {
            this._shopRepository = shopRepository ?? throw new ArgumentNullException(nameof(shopRepository));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var product = await _shopRepository.FindProductAsync(id);
            
            if (product == null) return NotFound();

            return Ok(product.ToApi());
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var list = new List<Product>();

            var products = await this._shopRepository.GetAllAsync(1, 25);

            foreach(var p in products)
                list.Add(p.ToApi());
            
            return list;
        }

        [HttpPost]
        public async Task<Product> CreateAsync(Product product)
        {
            var createdProduct = await this._shopRepository.CreateAsync(product.ToDomain());

            return createdProduct.ToApi();
        }
    }
}
