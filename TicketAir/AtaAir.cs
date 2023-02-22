namespace TicketAir;

//subsystem
public class AtaAir
{
    private readonly Ticket[] tickets = new[] {
        new Ticket(){FlightNumber = "AA1000",FlightTime = new DateTime(2022,1,1,12,20,00),Price=80000,From ="Gachsaran",To="Tehran" },
        new Ticket(){FlightNumber = "AA1000",FlightTime = new DateTime(2023,2,1,12,20,00),Price=75000,From ="khirabad",To="Tehran" },
        new Ticket(){FlightNumber = "AA3000",FlightTime = new DateTime(2023,5,1,12,20,00),Price=6454500,From ="Gachsaran",To="khirabad" },
        new Ticket(){FlightNumber = "AA8000",FlightTime = new DateTime(2024,4,1,12,20,00),Price=545454545,From ="Gachsaran",To="shiraz" },
        new Ticket(){FlightNumber = "AA4000",FlightTime = new DateTime(2023,3,1,12,20,00),Price=1212121,From ="Gachsaran",To="gilan" },
        new Ticket(){FlightNumber = "AA16000",FlightTime = new DateTime(2023,1,1,25,20,00),Price=1212121,From ="gilan",To="Tehran" },
    };


    public Ticket[] SearchFlights(DateTime date, string from, string to) => tickets.Where(x => x.FlightTime.Date == date.Date && x.From == from && x.To == to).ToArray();
}