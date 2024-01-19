using ActiveWear.Web.Mvc.Models;
using RestSharp;

namespace ActiveWear.Web.Mvc.Services
{
    public class ApiClient : IClient
    {
        public async Task<ProductViewModel?> FindProductAsync(int productId)
        {
            try
            {
                var options = new RestClientOptions("https://localhost:5000/api");

                using (var client = new RestClient(options))
                {
                    var request = new RestRequest($"products/{productId}", Method.Get);

                    var product = await client.GetAsync<ProductViewModel>(request);

                    return product;
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: gestire l'eccezione
            }
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllProductsAsync()
        {
            try
            {
                var options = new RestClientOptions("https://localhost:5000/api");

                using (var client = new RestClient(options))
                {
                    var request = new RestRequest($"products", Method.Get);

                    var products = await client.GetAsync<IEnumerable<ProductViewModel>>(request);

                    return products ?? new List<ProductViewModel>();
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: gestire l'eccezione
            }
        }
    }
}
