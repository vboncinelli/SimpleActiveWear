using Domain = ActiveWear.Core.Entities;
using EF = ActiveWear.Dal.Sql.Entities;

namespace ActiveWear.Dal.Sql.Mappers
{
    internal static class ProductMapper
    {
        internal static EF.Product ToDal(this Domain.Product entity)
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

        internal static Domain.Product ToDomain(this EF.Product dalEntity)
        {
            var category = dalEntity.ProductCategory?.ToDomain();
            var brand = dalEntity.ProductBrand?.ToDomain();

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

        internal static Domain.Category ToDomain(this EF.Category category)
        {
            var domainCategory = new Domain.Category(category.Name, category.Description);
            domainCategory.Id = category.Id;
            return domainCategory;
        }

        internal static Domain.Brand ToDomain(this EF.Brand brand)
        {
            var domainBrand = new Domain.Brand(brand.Name);
            domainBrand.Id = brand.Id;
            return domainBrand;
        }
    }
}
