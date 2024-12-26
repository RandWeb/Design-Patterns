namespace Creational.Builder.HtmlTagAndPersonBuilder.PersonBuilders;

public class PersonAddressBuilder : PersonBuilder
{
    public PersonAddressBuilder(Person person)
    {
        _person = person;
    }

    public PersonAddressBuilder At(string streetAddress)
    {
        _person.StreetAddress = streetAddress;
        return this;
    }
    public PersonAddressBuilder WithPostcode(string postCode)
    {
        _person.Postcode = postCode;
        return this;
    }
    public PersonAddressBuilder In(string city)
    {
        _person.City = city;
        return this;
    }
}