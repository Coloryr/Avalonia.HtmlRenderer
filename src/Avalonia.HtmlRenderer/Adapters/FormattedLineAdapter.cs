using Avalonia.Media.TextFormatting;
using TheArtOfDev.HtmlRenderer.Adapters;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;

namespace Avalonia.HtmlRenderer.Adapters;

public class FormattedLineAdapter(TextLine textLine) : RFormattedLine
{
    public TextLine TextLine { get; } = textLine;

    public override int Length => TextLine.Length;
    public override RSize Size => new RSize(TextLine.WidthIncludingTrailingWhitespace, TextLine.Height);
}