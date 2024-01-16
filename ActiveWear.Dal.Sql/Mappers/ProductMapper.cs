using Domain = ActiveWear.Core.Entities;
using EF = ActiveWear.Dal.Sql.Entities;

namespace ActiveWear.Dal.Sql.Mappers
{
    internal static class ProductMapper
    {
        public static EF.Product ToDal(this Domain.Product entity)
        {
            var dalEntity = new EF.Product()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                BrandId = entity.BrandId,
                CategoryId = entity.CategoryId,
                Price = entity.Price,
                ImageUri = entity.ImageUri,
            };

            return dalEntity;
        }

        public static Domain.Product ToDomain(this EF.Product dalEntity)
        {
            if (dalEntity.ProductCategory is null || dalEntity.ProductBrand is null)
            {
                var entity = new Domain.Product(
                    name: dalEntity.Name,
                    description: dalEntity.Description,
                    categoryId: dalEntity.CategoryId,
                    brandId: dalEntity.BrandId,
                    imageUri: dalEntity.ImageUri,
                    price: dalEntity.Price);

                entity.Id = dalEntity.Id;

                return entity;
            }
            else
            {
                var entity = new Domain.Product(
                    name: dalEntity.Name,
                    description: dalEntity.Description,
                    category: new Domain.Category(dalEntity.ProductCategory.Name, dalEntity.ProductCategory.Description),
                    brand: new Domain.Brand(dalEntity.ProductBrand.Name),
                    imageUri: dalEntity.ImageUri,
                    price: dalEntity.Price);

                entity.Id = dalEntity.Id;

                return entity;
            }
        }
    }
}
