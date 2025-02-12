namespace Structural.Decorator.Notification.RefactoredByDecoratorPattern;

public class FacebookNotifierDecorator(Notifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine("Sending Facebook notification.");
        Console.WriteLine($"Message: {message}");
    }
}

