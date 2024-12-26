using System.Text;

namespace Creational.Builder.HtmlTagAndPersonBuilder.GeneratorTags;

public class HtmlElement
{
    public string Name { get; private set; }
    public string Text { get; private set; }
    public List<HtmlElement> Elements = new();
    private const int indentSize = 2;

    public HtmlElement(string name)
    {
        Name = name;
    }
    public HtmlElement(string name, string text)
    {
        Name = name;
        Text = text;
    }

    private string ToStringImpl(int indent)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * indent);
        sb.Append($"{i}<{Name}>\n");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append(new string(' ', indentSize * (indent + 1)));
            sb.Append(Text);
            sb.Append("\n");
        }

        foreach (var e in Elements)
            sb.Append(e.ToStringImpl(indent + 1));

        sb.Append($"{i}</{Name}>\n");
        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }
}