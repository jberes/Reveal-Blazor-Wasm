namespace Reveal_Blazor_Wasm.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CustomersType>?> GetCustomers()
        {
            return Task.FromResult<List<CustomersType>?>(new());
        }
    }
}