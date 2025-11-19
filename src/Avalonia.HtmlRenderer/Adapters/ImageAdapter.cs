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

using Avalonia.Media.Imaging;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace Avalonia.HtmlRenderer.Adapters;

/// <summary>
/// Adapter for Avalonia Image object for core.
/// </summary>
/// <remarks>
/// Init.
/// </remarks>
/// <param name="image">
/// the underline Avalonia image.
/// </param>
internal sealed class ImageAdapter(Bitmap image) : RImage
{
    /// <summary>
    /// the underline Avalonia image.
    /// </summary>
    public Bitmap Image
    {
        get { return image; }
    }

    public override double Width
    {
        get { return image.PixelSize.Width; }
    }

    public override double Height
    {
        get { return image.PixelSize.Height; }
    }

    public override void Dispose()
    {
        image.Dispose();
    }
}