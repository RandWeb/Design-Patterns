using Design.DependencyInjection;

var greeter = new Greeter(new SystemDateTimeProvider());

var message = greeter.CreateGreetMessage();

Console.WriteLine(message);

Console.ReadKey();