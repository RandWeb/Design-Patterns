using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Composition;

public class DatabaseSoursedPersonalData : IPeopleDataReader
{
    public IEnumerable<Person> GetPeople()
    {

        Console.WriteLine("Read data from database");
        return new List<Person>
        {
            new("Mehrdad",26,"khairabad"),
            new("Yasin",29,"behbahan"),
            new("Fardin",31,"gachsaran"),
        };
    }
}
