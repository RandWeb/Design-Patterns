namespace Structural.Decorator.Notification.RefactoredByDecoratorPattern;

public class EmailNotifier(List<string> emails) : Notifier
{
    private readonly List<string> _emails = emails;

    public override void Send(string message)
    {
        Console.WriteLine($"Sending email notification to: {string.Join(", ", _emails)}");
        Console.WriteLine($"Email notification: {message}");
    }
}

