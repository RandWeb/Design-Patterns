namespace Structural.Decorator.Notification.RefactoredByDecoratorPattern;

public class SmsNotifierDecorator (Notifier notifier) : NotifierDecorator(notifier)
{
    public override void Send(string message)
    {
        base.Send(message);
        Console.WriteLine($"SMS notification: {message}");
    }
}

