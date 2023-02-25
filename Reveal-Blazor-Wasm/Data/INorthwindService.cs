namespace Reveal_Blazor_Wasm.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>?> GetCustomers();
    }
}