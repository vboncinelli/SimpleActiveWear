using ActiveWear.Web.Mvc.Models;
using Microsoft.Extensions.Options;
using RestSharp;

namespace ActiveWear.Web.Mvc.Services
{
    public class ApiClient : IClient
    { 
        private readonly RestClientOptions _options;

        public ApiClient()
        {
            this._options = new RestClientOptions("https://localhost:5000/api");
        }

        public async Task<ProductViewModel?> FindProductAsync(int productId)
        {
            try
            {

                using (var client = new RestClient(this._options))
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
                using (var client = new RestClient(this._options))
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

        public async Task<ProductViewModel?> AddProductAsync(ProductViewModel model)
        {
            try
            {
                using (var client = new RestClient(this._options))
                {
                    var request = new RestRequest($"products", Method.Post);
                    
                    request.AddJsonBody(model);

                    var product = await client.PostAsync<ProductViewModel>(request);

                    return product;
                }
            }
            catch (Exception ex)
            {
                throw; //TODO: gestire l'eccezione
            }
        }
    }
}
