using ActiveWear.Web.Mvc.Models;

namespace ActiveWear.Web.Mvc.Services
{
    public interface IClient
    {
        Task<ProductViewModel?> AddProductAsync(ProductViewModel model);

        Task<ProductViewModel?> FindProductAsync(int productId);

        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
    }
}
