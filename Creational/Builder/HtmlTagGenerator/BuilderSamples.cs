using System.Text;
using Creational.Builder.HtmlTagAndPersonBuilder.PersonBuilders;
using Creational.Builder.HtmlTagAndPersonBuilder.GeneratorTags;
using static System.Console;

namespace Creational.Builder.HtmlTagAndPersonBuilder;

public class BuilderSamples
{
    public static void HtmlTagGenerator()
    {

        string hello = "hello";
        var sb = new StringBuilder();
        sb.Append("<p>");
        sb.Append(hello);
        sb.Append("</p>");
        WriteLine(sb);


        var words = new[] { "hello", "world" };
        sb.Clear();
        sb.Append("<ul>");
        foreach (var word in words)
        {
            sb.AppendFormat("<li>{0}</li>", word);
        }

        sb.Append("</ul>");
        WriteLine(sb);


        var builder = new HtmlBuilder("ul");
        builder
            .AddChild("li", "hello");
        builder
            .AddChild("li", "world");
        WriteLine(builder.ToString());


        sb.Clear();
        builder.Clear();
        builder
            .AddChildFluent("li", "hello")
            .AddChildFluent("li", "world");
        WriteLine(builder);
    }

    public static void PersonBuilder()
    {
        var pb = new PersonBuilder();
        Person person = pb
            .Lives
            .At("khairabad")
            .In("gahsaran")
            .WithPostcode("123645978")
            .Works
            .At("tehran")
            .AsA("developer")
            .Earning(40_000_000);

        WriteLine(person);
    }
}