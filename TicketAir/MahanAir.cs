namespace TicketAir;

//subsystem
public class MahanAir
{
    private readonly Ticket[] tickets = new[] {
        new Ticket(){FlightNumber = "MA1000",FlightTime = new DateTime(2023,1,1,12,20,00),Price=80000,From ="Gachsaran",To="Tehran" },
        new Ticket(){FlightNumber = "MA1000",FlightTime = new DateTime(2023,2,1,12,20,00),Price=75000,From ="khirabad",To="Tehran" },
        new Ticket(){FlightNumber = "MA3000",FlightTime = new DateTime(2023,5,1,12,20,00),Price=6454500,From ="Gachsaran",To="khirabad" },
        new Ticket(){FlightNumber = "MA8000",FlightTime = new DateTime(2023,4,1,12,20,00),Price=545454545,From ="Gachsaran",To="shiraz" },
        new Ticket(){FlightNumber = "LA4000",FlightTime = new DateTime(2023,3,1,12,20,00),Price=1212121,From ="Gachsaran",To="gilan" },
        new Ticket(){FlightNumber = "LA6000",FlightTime = new DateTime(2023,1,1,25,20,00),Price=1212121,From ="gilan",To="Tehran" },
    };


    public Ticket[] SearchFlights(DateTime date, string from, string to) => tickets.Where(x => x.FlightTime.Date == date.Date && x.From == from && x.To == to).ToArray();
}
