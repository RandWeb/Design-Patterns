
// component Base
internal abstract class AirlineBase(IAirTraficControlMediator mediator)
{
    protected readonly IAirTraficControlMediator _mediator = mediator;

    public abstract void Send(string message);
    public abstract void Receive(string message, string sender);
}
