namespace Reporting;

//Director
public class ReportDirector
{
    private IReportBuilder _builder;

    public ReportDirector(IReportBuilder builder)
    {
        _builder = builder;
    }

    public Document Create(string file)
    {
       // var content = LoadFile();

        _builder.AddTitle("title");

        _builder.AddParagraph("paragraph");

        _builder.Footer("footer");

        return _builder.Build();
    }
}

