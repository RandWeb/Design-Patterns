namespace Structural.Decorator.Notification.Legacy;

public class EmailAndSMSNotifier(List<string> emails) : Notifier
{
    private readonly EmailNotifier _emailNotifier = new(emails);
    private readonly SmsNotifier _smsNotifier = new();

    public override void Send(string message)
    {
        _emailNotifier.Send(message);
        _smsNotifier.Send(message);
    }
}

