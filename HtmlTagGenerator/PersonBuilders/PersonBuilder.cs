namespace Creational.Builder.HtmlTagAndPersonBuilder.PersonBuilders;

public class PersonBuilder //facade
{
    //reference
    protected Person _person = new();

    public PersonJobBuilder Works => new(_person);
    public PersonAddressBuilder Lives => new(_person);

    public static implicit operator Person(PersonBuilder personBuilder) => personBuilder._person;
}