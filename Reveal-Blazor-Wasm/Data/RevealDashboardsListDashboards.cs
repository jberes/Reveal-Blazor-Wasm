//namespace Reveal_Blazor_Wasm.Data.RevealDashboardsList; // Razor won't recognize third level namespace
namespace Reveal_Blazor_Wasm.RevealDashboardsList;

public class DashboardsType
{
    public string? Title { get; set; }
    public string? AddedBy { get; set; }
    public string? AddedByImageUrl { get; set; }
    public DateTime? DateAdded { get; set; }
    public DateTime? DateChanged { get; set; }
    public string? Thumbnail { get; set; }
    public string? ThumbnailURL { get; set; }
    public string? Desciption { get; set; }
}
