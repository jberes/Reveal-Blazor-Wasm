using System.Net.Http.Json;

namespace Reveal_Blazor_Wasm.RevealDashboardsList
{
    public class RevealDashboardsListService: IRevealDashboardsListService
    {
        private readonly HttpClient _http;

        public RevealDashboardsListService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<DashboardsType>?> GetDashboards()
        {
            return await this._http.GetFromJsonAsync<List<DashboardsType>>("https://excel2json.io/api/share/9d984c93-9ddc-422c-436f-08da496bf5f2");
        }
    }
}