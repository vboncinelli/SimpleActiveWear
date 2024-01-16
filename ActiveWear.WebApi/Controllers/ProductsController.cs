using ActiveWear.Core.Interfaces;
using ApiEntities = ActiveWear.WebApi.Models;
using Domain = ActiveWear.Core.Entities;
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
            Domain.Product? product = await _shopRepository.FindProductAsync(id);
            if (product == null)
                return NotFound();

            var apiProduct = new ApiEntities.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };

            return Ok(apiProduct);
        }
    }
}
