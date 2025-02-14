namespace Structural.Decorator.Notification.Legacy;

public class EmailFacebookAndSlackNotifier(List<string> emails) : Notifier
{
    private readonly EmailNotifier _emailNotifier = new(emails);
    private readonly FacebookNotifier _facebookNotifier = new();
    private readonly SlackNotifier _slackNotifier = new();

    public override void Send(string message)
    {
        _emailNotifier.Send(message);
        _facebookNotifier.Send(message);
        _slackNotifier.Send(message);
    }
}

