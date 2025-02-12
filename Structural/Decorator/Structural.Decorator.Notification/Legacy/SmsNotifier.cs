namespace Structural.Decorator.Notification.Legacy;

public class SmsNotifier : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine($"SMS notification: {message}");
    }
}

