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
/// Adapter for Avalonia Font family object for core.
/// </summary>
/// <remarks>
/// Init.
/// </remarks>
/// <param name="fontFamily">
/// the underline win-forms font.
/// </param>
internal sealed class FontFamilyAdapter(FontFamily fontFamily) : RFontFamily
{
    /// <summary>
    /// the underline Avalonia font family.
    /// </summary>
    public FontFamily FontFamily => fontFamily;

    public override string Name => fontFamily.Name;
}