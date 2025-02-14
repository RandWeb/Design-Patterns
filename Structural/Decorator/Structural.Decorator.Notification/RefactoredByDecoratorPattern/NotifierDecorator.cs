namespace Structural.Decorator.Notification.RefactoredByDecoratorPattern;

public abstract class NotifierDecorator(Notifier notifier) : Notifier
{
    protected readonly Notifier _notifier = notifier;

    public override void Send(string message)
    {
        if (_notifier != null)
        {
            _notifier.Send(message);
        }
    }
}

