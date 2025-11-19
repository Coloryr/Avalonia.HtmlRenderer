// "Therefore those skilled at the unorthodox
// are infinite as heaven and earth,
// inexhaustible as the great rivers.
// When they come to an end,
// they begin again,
// like the days and months;
// they die and are reborn,
// like the four seasons."
// 
// - Sun Tsu,
// "The Art of War"

using Avalonia.Media;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Avalonia.HtmlRenderer.Adapters;

/// <summary>
/// Adapter for Avalonia brushes.
/// </summary>
/// <remarks>
/// Init.
/// </remarks>
/// <param name="brush">
/// The actual Avalonia brush instance.
/// </param>
internal sealed class BrushAdapter(IImmutableBrush brush) : RBrush
{
    /// <summary>
    /// The actual Avalonia brush instance.
    /// </summary>
    public IImmutableBrush Brush
    {
        get { return brush; }
    }

    public override void Dispose()
    { }
}