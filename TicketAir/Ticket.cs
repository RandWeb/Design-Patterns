namespace TicketAir;

public class Ticket
{
    public DateTime FlightTime { get; set; }
    public string FlightNumber { get; set; }
    public string From { get; set; }
    public string To { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"{From}-{To}, {FlightTime}, Number:{FlightNumber},Price: {Price}";
    }
}
