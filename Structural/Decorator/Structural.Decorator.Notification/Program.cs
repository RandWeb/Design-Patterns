// Create a _notifier that sends only emails
//using Structural.Decorator.Notification.Legacy;
using Structural.Decorator.Notification.RefactoredByDecoratorPattern;

// legacy
/*
var emailNotifier = new EmailNotifier(["user1@example.com", "user2@example.com"]);
emailNotifier.Send("This is an email notification!");

Console.WriteLine();

// Create a _notifier that sends both emails and SMS
var emailAndSMSNotifier = new EmailAndSMSNotifier(["user1@example.com", "user2@example.com"]);
emailAndSMSNotifier.Send("This is an email and SMS notification!");

Console.WriteLine();

// Create a _notifier that sends emails, Facebook, and Slack notifications
var emailFacebookAndSlackNotifier = new EmailFacebookAndSlackNotifier(["user1@example.com", "user2@example.com"]);
emailFacebookAndSlackNotifier.Send("This is an email, Facebook, and Slack notification!");
*/

// Create the basic notifier with a list of emails.
var emailNotifier = new EmailNotifier(["user1@example.com", "user2@example.com"]);

// Decorate the notifier with additional notification types.
var decoratedNotifier = new SmsNotifierDecorator(
    new FacebookNotifierDecorator(
        new SlackNotifierDecorator(emailNotifier)));

// Send a message using all decorators.
decoratedNotifier.Send("This is an important notification!");
Console.ReadLine();