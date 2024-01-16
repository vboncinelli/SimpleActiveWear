using ApiModels = ActiveWear.WebApi.Models;
using Domain = ActiveWear.Core.Entities;

namespace ActiveWear.WebApi.Mappers
{
    public static class ProductMapping
    {
        public static Domain.Product ToDomain(this ApiModels.Product product)
        {
            var entity = new Domain.Product(
                name: product.Name,
                price: product.Price,
                categoryId: product.CategoryId,
                brandId: product.BrandId,
                description: product.Description);

            entity.Id = product.Id;

            return entity;
        }

        public static ApiModels.Product? ToApi(this Domain.Product? product)
        {
            if (product == null) return null;

            var entity = new ApiModels.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                Description = product.Description
            };

            return entity;
        }
    }
}
