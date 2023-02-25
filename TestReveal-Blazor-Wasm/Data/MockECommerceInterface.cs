namespace Reveal_Blazor_Wasm.ECommerce
{
    public class MockECommerceService : IECommerceService
    {
        public Task<List<RevenueType>?> GetRevenue()
        {
            return Task.FromResult<List<RevenueType>?>(new());
        }
    }
}