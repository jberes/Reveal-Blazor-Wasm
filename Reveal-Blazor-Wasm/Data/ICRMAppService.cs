namespace Reveal_Blazor_Wasm.CRMApp
{
    public interface ICRMAppService
    {
        Task<List<MeetingsTasksType>?> GetMeetingsTasks();
    }
}