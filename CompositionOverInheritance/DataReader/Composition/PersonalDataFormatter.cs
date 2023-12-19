using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Composition;

public class PersonalDataFormatter : IFormatter
{
    private readonly IPeopleDataReader _peopleDataReader;

    public PersonalDataFormatter(IPeopleDataReader peopleDataReader)
    {
        _peopleDataReader = peopleDataReader;
    }

    public string Format()
    {
        IEnumerable<Person> people = _peopleDataReader.GetPeople();
        return string.Join("\n", people.Select(p => $"{p.Name} born in {p.City} on {p.Year}"));
    }
}