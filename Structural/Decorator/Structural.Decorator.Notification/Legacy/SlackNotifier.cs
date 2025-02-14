namespace Structural.Decorator.Notification.Legacy;

public class SlackNotifier : Notifier
{
    public override void Send(string message)
    {
        Console.WriteLine("Sending Slack notification.");
        Console.WriteLine($"Message: {message}");
    }
}

