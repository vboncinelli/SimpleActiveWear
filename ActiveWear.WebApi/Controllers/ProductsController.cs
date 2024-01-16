using ActiveWear.Core.Interfaces;
using ActiveWear.WebApi.Mappers;
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
    }
}
