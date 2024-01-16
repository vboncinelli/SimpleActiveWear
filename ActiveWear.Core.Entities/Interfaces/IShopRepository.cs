using ActiveWear.Core.Entities;

namespace ActiveWear.Core.Interfaces
{
    public interface IShopRepository
    {
        Task<Product?> FindProductAsync(int id);
    }
}
