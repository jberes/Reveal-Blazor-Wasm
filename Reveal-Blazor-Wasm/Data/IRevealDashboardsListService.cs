namespace Reveal_Blazor_Wasm.RevealDashboardsList
{
    public interface IRevealDashboardsListService
    {
        Task<List<DashboardsType>?> GetDashboards();
    }
}