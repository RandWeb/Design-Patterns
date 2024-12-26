using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Inheritance;

public class ExcelSourcedPersonalData : PersonalDataFormatter
{
    protected override IEnumerable<Person> GetPeople()
    {
        Console.WriteLine("Read data from excel");
        return new List<Person>
        {
            new("mehrdad",26,"khairabad"),
            new("yasin",29,"behbahan"),
            new("fardin",29,"gachsaran"),
        };
    }
}
