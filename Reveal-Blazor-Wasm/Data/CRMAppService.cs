using System.Net.Http.Json;

namespace Reveal_Blazor_Wasm.CRMApp
{
    public class CRMAppService: ICRMAppService
    {
        private readonly HttpClient _http;

        public CRMAppService(HttpClient http)
        {
            this._http = http;
        }

        public async Task<List<MeetingsTasksType>?> GetMeetingsTasks()
        {
            return await this._http.GetFromJsonAsync<List<MeetingsTasksType>>("https://excel2json.io/api/share/2fd4ecd6-da6c-4e37-e666-08dab79fa5b4");
        }
    }
}