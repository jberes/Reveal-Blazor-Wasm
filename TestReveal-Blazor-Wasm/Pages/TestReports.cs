using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;
using Reveal_Blazor_Wasm.RevealDashboardsList;

namespace TestReveal_Blazor_Wasm
{
	public class TestReports
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule),
				typeof(IgbRippleModule));
			ctx.Services.AddScoped<IRevealDashboardsListService>(sp => new MockRevealDashboardsListService());
			var componentUnderTest = ctx.RenderComponent<Reports>();
			Assert.NotNull(componentUnderTest);
		}
	}
}