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

namespace TheArtOfDev.HtmlRenderer.Demo.Common;

/// <summary>
/// Used to hold a single html sample with its name.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="T:System.Object"/> class.
/// </remarks>
public sealed class HtmlSample(string name, string fullName, string html)
{
    public string Name => name;

    public string FullName => fullName;

    public string Html => html;
}