using BlazorMaster.Shared;
using System.Net.Http.Json;

namespace BlazorMaster.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<ProductDTO>> List()
        {
            var list = new List<ProductDTO>();
            list = await _http.GetFromJsonAsync<List<ProductDTO>>("api/Product");

            return list!;
        }
    }
}
