using ActiveWear.Core.Exceptions;
using ActiveWear.Core.Interfaces;
using ActiveWear.Dal.Mappers;
using ActiveWear.Dal.Sql.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Domain = ActiveWear.Core.Entities;

namespace ActiveWear.Dal.Sql
{
    public class ShopRepository : IShopRepository
    {
        private readonly string _connectionString;

        public ShopRepository(IConfiguration configuration)
        {
            this._connectionString = configuration.GetConnectionString("ActiveWearShop") ?? throw new ArgumentNullException(nameof(_connectionString));
        }

        public async Task<Domain.Product?> FindProductAsync(int id)
        {
            try
            {
                using (var context = this.GetContext())
                {
                    var product = await context.Products
                        .Include(e => e.ProductBrand)
                        .Include(e => e.ProductCategory)
                        .FirstOrDefaultAsync(product => product.Id == id);

                    if (product == null) return null;

                    return product.ToDomain();
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public async Task<IEnumerable<Domain.Product>> GetAllAsync(int page, int pageSize)
        {
            try
            {
                using (var context = this.GetContext())
                {
                    var products = await context.Products
                        .Include(e => e.ProductBrand)
                        .Include(e => e.ProductCategory)
                        .OrderBy(e => e.Id)
                        .Skip((page - 1) * pageSize)
                        .Take(pageSize)
                        .ToListAsync();

                    var collection = new List<Domain.Product>();
                    foreach (var product in products)
                        collection.Add(product.ToDomain());

                    return collection;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public async Task<Domain.Product> CreateAsync(Domain.Product product)
        {
            using (var context = this.GetContext())
            {
                var dalProduct = product.ToDal();

                var attached = context.Products.Attach(dalProduct);
                attached.State = EntityState.Added;

                await context.SaveChangesAsync();

                var newEntity = await this.FindProductAsync(attached.Entity.Id);

                return newEntity!;
            }
        }

        public async Task<Domain.Product> UpdateAsync(Domain.Product product)
        {
            try
            {
                using (var context = this.GetContext())
                {
                    var dalProduct = product.ToDal();

                    var attached = context.Products.Attach(dalProduct);

                    attached.State = EntityState.Modified;

                    await context.SaveChangesAsync();

                    return product;
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                using (var context = this.GetContext())
                {
                    var deletedRows = await context.Products.Where(e => e.Id == id).ExecuteDeleteAsync();

                    if (deletedRows == 0)
                        throw new EntityNotFoundException($"Product with Id {id} not found");
                }
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ex.Message, ex);
            }
        }

        protected virtual ActiveWearContext GetContext()
        {
            return new ActiveWearContext(this._connectionString);
        }
    }
}
