using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;

namespace TestReveal_Blazor_Wasm
{
	public class TestContracts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Contracts>();
			Assert.NotNull(componentUnderTest);
		}
	}
}