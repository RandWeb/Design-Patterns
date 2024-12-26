namespace Creational.Builder.HtmlTagAndPersonBuilder.PersonBuilders;

public class Person
{
    //Address
    public string StreetAddress { get; set; }
    public string Postcode { get; set; }
    public string City { get; set; }

    //Employment
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public int AnnualIncome { get; set; }

    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
    }
}