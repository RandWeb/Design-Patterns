using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Inheritance;

public class DatabaseSourcedPersonalData : PersonalDataFormatter
{
    protected override IEnumerable<Person> GetPeople()
    {
        Console.WriteLine("Read data from database");
        return new List<Person>
        {
            new("mehrdad",26,"khairabad"),
            new("yasin",29,"behbahan"),
            new("fardin",29,"gachsaran"),
        };
    }
}
