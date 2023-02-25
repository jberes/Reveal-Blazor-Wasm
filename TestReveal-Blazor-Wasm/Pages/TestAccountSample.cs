using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;

namespace TestReveal_Blazor_Wasm
{
	public class TestAccountSample
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbTabsModule),
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbExpansionPanelModule),
				typeof(IgbAvatarModule),
				typeof(IgbCheckboxModule),
				typeof(IgbListModule),
				typeof(IgbChipModule));
			var componentUnderTest = ctx.RenderComponent<AccountSample>();
			Assert.NotNull(componentUnderTest);
		}
	}
}