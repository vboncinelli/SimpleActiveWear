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
                description: product.Description,
                imageUri: product.ImageUri);

            entity.Id = product.Id;

            return entity;
        }

        public static ApiModels.Product ToApi(this Domain.Product product)
        {
            var entity = new ApiModels.Product()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                ImageUri = product.ImageUri,
                Description = product.Description,
                ProductBrand = product.ProductBrand?.ToApi(),
                ProductCategory = product.ProductCategory?.ToApi()
            };

            return entity;
        }

        public static ApiModels.Brand ToApi(this Domain.Brand brand)
        {
            var entity = new ApiModels.Brand()
            {
                Id = brand.Id,
                Name = brand.Name,
            };

            return entity;
        }

        public static ApiModels.Category ToApi(this Domain.Category category)
        {
            var entity = new ApiModels.Category()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };

            return entity;
        }
    }
}
