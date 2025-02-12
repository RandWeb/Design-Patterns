namespace Structural.Decorator.Notification.Legacy;

public class FacebookNotifier : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine("Sending Facebook notification.");
        Console.WriteLine($"Message: {message}");
    }
}

