using CompositionOverInheritance.DataReader.Models;

namespace CompositionOverInheritance.DataReader.Composition;

public interface IPeopleDataReader
{
    public IEnumerable<Person> GetPeople() => throw new NotImplementedException();
}
