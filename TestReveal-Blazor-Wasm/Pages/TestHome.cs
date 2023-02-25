using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;
using Reveal_Blazor_Wasm.ECommerce;
using Reveal_Blazor_Wasm.Northwind;
using Reveal_Blazor_Wasm.CRMApp;

namespace TestReveal_Blazor_Wasm
{
	public class TestHome
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbCategoryChartModule),
				typeof(IgbGridModule),
				typeof(IgbListModule),
				typeof(IgbAvatarModule),
				typeof(IgbChipModule));
			ctx.Services.AddScoped<IECommerceService>(sp => new MockECommerceService());
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			ctx.Services.AddScoped<ICRMAppService>(sp => new MockCRMAppService());
			var componentUnderTest = ctx.RenderComponent<Home>();
			Assert.NotNull(componentUnderTest);
		}
	}
}