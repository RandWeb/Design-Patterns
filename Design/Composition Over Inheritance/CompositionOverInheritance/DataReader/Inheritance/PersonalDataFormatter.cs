using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Inheritance;

public abstract class PersonalDataFormatter
{
    public string Format()
    {
        IEnumerable<Person> people = GetPeople();
        return string.Join("\n", people.Select(p => $"{p.Name} born in {p.City} on {p.Year}"));
    }

    protected abstract IEnumerable<Person> GetPeople();
}
