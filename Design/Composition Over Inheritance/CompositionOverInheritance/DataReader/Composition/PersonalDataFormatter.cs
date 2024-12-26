using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Composition;

public class PersonalDataFormatter(IPeopleDataReader peopleDataReader) : IFormatter
{
    public string Format()
    {
        IEnumerable<Person> people = peopleDataReader.GetPeople();
        return string.Join("\n", people.Select(p => $"{p.Name} born in {p.City} on {p.Year}"));
    }
}