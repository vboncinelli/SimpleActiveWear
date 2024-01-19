using ActiveWear.Core.Entities;

namespace ActiveWear.Core.Interfaces
{
    public interface IShopRepository
    {
        Task<Product?> FindProductAsync(int id);

        Task<IEnumerable<Product>> GetAllAsync(int page, int pageSize);

        Task<Product> CreateAsync(Product product);
    }
}
