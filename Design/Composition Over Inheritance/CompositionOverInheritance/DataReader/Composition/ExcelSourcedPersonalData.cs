using System.Collections.Generic;
using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Composition;

public class ExcelSourcedPersonalData : IPeopleDataReader
{
    public IEnumerable<Person> GetPeople()
    {

        Console.WriteLine("Read data from excel");
        return new List<Person>
        {
            new("Mehrdad",26,"khairabad"),
            new("Yasin",29,"behbahan"),
            new("Fardin",31,"gachsaran"),
        };
    }
}