

//Boeing Concrete Component
internal sealed class BoeingAirlineComponent(IAirTraficControlMediator mediator) : AirlineBase(mediator)
{
    public override void Send(string message)
    {
        _mediator.SendMessage(this, message);
    }
    public override void Receive(string message, string sender)
    {
        Console.WriteLine($"Boeing from {sender} received : {message}");
    }
}