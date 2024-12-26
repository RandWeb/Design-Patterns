
// concrete mediator
internal class AirTraficControlConcreteMediator : IAirTraficControlMediator
{
    private List<AirlineBase> _airlines = [];
    public void RegisterAirline(params AirlineBase[] airline)
    {
        _airlines.AddRange(airline);
    }
    public void SendMessage(AirlineBase airlineBase,string message)
    {
        foreach (var airline in _airlines.Where(p=>p != airlineBase).ToList())
        {
            airline.Receive(message, airlineBase.GetType().FullName);
        }
    }
}

