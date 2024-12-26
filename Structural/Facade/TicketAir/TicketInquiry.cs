namespace TicketAir;

//facade
public class TicketInquiry
{
    public List<Ticket> Inquiry(DateTime date, string from, string to)
    {
        var iranAirFlights = new IranAir().SearchFlights(date, from, to);
        var mahanAirFlights = new MahanAir().SearchFlights(date, from, to);
        var ataAirFlights = new AtaAir().SearchFlights(date, from, to);
        var tickets = new List<Ticket>();
        tickets.AddRange(iranAirFlights);
        tickets.AddRange(mahanAirFlights);
        tickets.AddRange(ataAirFlights);
        return tickets.OrderBy(x => x.Price).ToList();
    }
}
