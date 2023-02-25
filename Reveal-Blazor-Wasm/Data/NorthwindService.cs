using System.Net.Http.Json;

namespace Reveal_Blazor_Wasm.Northwind
{
    public class NorthwindService: INorthwindService
    {
        private readonly HttpClient _http;

        public NorthwindService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<CustomersType>?> GetCustomers()
        {
            return await this._http.GetFromJsonAsync<List<CustomersType>>("/static-data/northwind-customers.json");
        }
    }
}