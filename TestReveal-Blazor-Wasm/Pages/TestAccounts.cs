using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;
using Reveal_Blazor_Wasm.Northwind;

namespace TestReveal_Blazor_Wasm
{
	public class TestAccounts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbGridModule));
			ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
			var componentUnderTest = ctx.RenderComponent<Accounts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}