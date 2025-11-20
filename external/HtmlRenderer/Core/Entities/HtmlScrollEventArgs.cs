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

using System;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace TheArtOfDev.HtmlRenderer.Core.Entities;

/// <summary>
/// Raised when Html Renderer request scroll to specific location.<br/>
/// This can occur on document anchor click.
/// </summary>
/// <remarks>
/// Init.
/// </remarks>
/// <param name="location">the location to scroll to</param>
public sealed class HtmlScrollEventArgs(RPoint location) : EventArgs
{
    /// <summary>
    /// the x location to scroll to
    /// </summary>
    public double X
    {
        get { return location.X; }
    }

    /// <summary>
    /// the x location to scroll to
    /// </summary>
    public double Y
    {
        get { return location.Y; }
    }

    public override string ToString()
    {
        return string.Format("Location: {0}", location);
    }
}