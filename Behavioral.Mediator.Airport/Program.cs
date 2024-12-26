

AirTraficControlConcreteMediator mediator = new();

AirbusAirlineComponent airbusAirline = new(mediator);

BoeingAirlineComponent boeingAirline = new(mediator);

mediator.RegisterAirline(airbusAirline, boeingAirline);

airbusAirline.Send("Can we land right now ?");
Console.WriteLine("----------");

boeingAirline.Send("No! we're landing, wait ...");
Console.WriteLine("----------");

// Demonstrate landing ...
Console.WriteLine("Boeing is landing ...");
await Task.Delay(TimeSpan.FromSeconds(3));
Console.WriteLine("----------");

boeingAirline.Send("Landed.");
Console.WriteLine("----------");

airbusAirline.Send("OK, we're going to land ...");
Console.WriteLine("----------");

boeingAirline.Send("Good luck.");