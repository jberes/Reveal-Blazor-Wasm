namespace Reveal_Blazor_Wasm.CRMApp
{
    public class MockCRMAppService : ICRMAppService
    {
        public Task<List<MeetingsTasksType>?> GetMeetingsTasks()
        {
            return Task.FromResult<List<MeetingsTasksType>?>(new());
        }
    }
}