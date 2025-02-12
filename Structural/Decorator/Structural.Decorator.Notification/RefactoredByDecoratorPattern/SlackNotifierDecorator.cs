namespace Structural.Decorator.Notification.RefactoredByDecoratorPattern;

public class SlackNotifierDecorator(Notifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending Slack notification.");
        Console.WriteLine($"Message: {message}");
    }
}

