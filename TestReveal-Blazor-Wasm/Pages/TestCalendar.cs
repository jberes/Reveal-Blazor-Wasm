using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Reveal_Blazor_Wasm.Pages;

namespace TestReveal_Blazor_Wasm
{
	public class TestCalendar
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Calendar>();
			Assert.NotNull(componentUnderTest);
		}
	}
}