
// component Base
//Airbus Concrete Component
internal sealed class AirbusAirlineComponent(IAirTraficControlMediator mediator) : AirlineBase(mediator)
{
    public override void Send(string message)
    {
        _mediator.SendMessage(this,message);
    }
    public override void Receive(string message,string sender)
    {
        Console.WriteLine($"Airbus from {sender} received : {message}");
    }
}
