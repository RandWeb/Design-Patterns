namespace Design.DependencyInjection;

public class SystemDateTimeProvider : IDateTimeProvider
{
    public DateTime DateTime => DateTime.UtcNow;
}
