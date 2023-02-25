namespace Reveal_Blazor_Wasm.ECommerce
{
    public interface IECommerceService
    {
        Task<List<RevenueType>?> GetRevenue();
    }
}