namespace Design.DependencyInjection;
public class Greeter(IDateTimeProvider dateTimeProvider)
{
    private readonly IDateTimeProvider _dateTimeProvider = dateTimeProvider;


    public string CreateGreetMessage()
    {
        var dataTimeNow = _dateTimeProvider.DateTime;

        return dataTimeNow.Hour switch
        {
            >= 5 and < 12 => "good morning",
            >= 12 and < 16 => "good afternoon",
            _ => "good evening"
        };
    }
}
