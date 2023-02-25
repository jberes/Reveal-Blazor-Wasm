using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Reveal_Blazor_Wasm;
using Reveal_Blazor_Wasm.ECommerce;
using Reveal_Blazor_Wasm.Northwind;
using Reveal_Blazor_Wasm.CRMApp;
using Reveal_Blazor_Wasm.RevealDashboardsList;
using IgniteUI.Blazor.Controls;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IECommerceService>(sp => new ECommerceService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<INorthwindService>(sp => new NorthwindService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<ICRMAppService>(sp => new CRMAppService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
builder.Services.AddScoped<IRevealDashboardsListService>(sp => new RevealDashboardsListService(new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)}));
RegisterIgniteUI(builder.Services);

await builder.Build().RunAsync();

void RegisterIgniteUI(IServiceCollection services)
{
    services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule),
        typeof(IgbCategoryChartModule),
        typeof(IgbGridModule),
        typeof(IgbChipModule),
        typeof(IgbButtonModule),
        typeof(IgbInputModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbTabsModule),
        typeof(IgbExpansionPanelModule),
        typeof(IgbCheckboxModule),
        typeof(IgbCardModule)
    );
}