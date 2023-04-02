using BlazorMaster.Shared;
using System.Net.Http.Json;

namespace BlazorMaster.Client.Services
{
    public class SaleService : ISaleService
    {
        private readonly HttpClient _http;

        public SaleService(HttpClient http)
        {
            _http = http;
        }
        public async Task<bool> Get(SaleDTO saleDTO)
        {
            var response = await _http.PostAsJsonAsync("api/Sale", saleDTO);
            var result = response.IsSuccessStatusCode;

            return result;
        }
    }
}
