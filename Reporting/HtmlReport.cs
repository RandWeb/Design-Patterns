namespace Reporting;

//Concrete Builder
public class HtmlReport : IReportBuilder
{
    private HtmlDocument _document;

    public HtmlReport(HtmlDocument document)
    {
        _document = document;
    }

    public void AddParagraph(string content)
    {
        throw new NotImplementedException();
    }

    public void AddTitle(string title)
    {
        throw new NotImplementedException();
    }

    public Document Build()
    {
        return _document;
    }

    public void Footer(string text)
    {
        throw new NotImplementedException();
    }
}

