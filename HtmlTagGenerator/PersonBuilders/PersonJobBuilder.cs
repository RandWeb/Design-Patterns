﻿namespace Creational.Builder.HtmlTagAndPersonBuilder.PersonBuilders;

public class PersonJobBuilder : PersonBuilder
{
    public PersonJobBuilder(Person person)
    {
        _person = person;
    }

    public PersonJobBuilder At(string companyName)
    {
        _person.CompanyName = companyName;
        return this;
    }
    public PersonJobBuilder AsA(string position)
    {
        _person.Position = position;
        return this;
    }
    public PersonJobBuilder Earning(int amount)
    {
        _person.AnnualIncome = amount;
        return this;
    }
}