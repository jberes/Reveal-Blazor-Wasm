namespace Reveal_Blazor_Wasm.RevealDashboardsList
{
    public class MockRevealDashboardsListService : IRevealDashboardsListService
    {
        public Task<List<DashboardsType>?> GetDashboards()
        {
            return Task.FromResult<List<DashboardsType>?>(new());
        }
    }
}