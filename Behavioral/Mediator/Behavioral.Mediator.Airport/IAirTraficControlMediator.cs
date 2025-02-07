
// mediator
internal interface IAirTraficControlMediator
{
    void RegisterAirline(params AirlineBase[] airline);
    void SendMessage(AirlineBase airlineBase, string message);
}
//AirbusAirLine,BoeingAirlineComponent

