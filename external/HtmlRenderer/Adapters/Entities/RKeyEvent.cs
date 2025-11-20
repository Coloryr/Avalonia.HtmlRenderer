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

using TheArtOfDev.HtmlRenderer.Core;

namespace TheArtOfDev.HtmlRenderer.Adapters.Entities;

/// <summary>
/// Even class for handling keyboard events in <see cref="HtmlContainerInt"/>.
/// </summary>
/// <remarks>
/// Init.
/// </remarks>
/// <param name="control">
/// is control is pressed
/// </param>
/// <param name="aKeyCode">
/// is 'A' key is pressed
/// </param>
/// <param name="cKeyCode">
/// is 'C' key is pressed
/// </param>
public sealed class RKeyEvent(bool control, bool aKeyCode, bool cKeyCode)
{
    /// <summary>
    /// is control is pressed
    /// </summary>
    public bool Control
    {
        get { return control; }
    }

    /// <summary>
    /// is 'A' key is pressed
    /// </summary>
    public bool AKeyCode
    {
        get { return aKeyCode; }
    }

    /// <summary>
    /// is 'C' key is pressed
    /// </summary>
    public bool CKeyCode
    {
        get { return cKeyCode; }
    }
}