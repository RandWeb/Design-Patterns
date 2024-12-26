namespace CompositionOverInheritance.DataReader.Models;

public class Person
{
    public Person(string name, int year, string city)
    {
        Name = name;
        Year = year;
        City = city;
    }

    public string Name { get; set; }
    public int Year { get; set; }
    public string City { get; set; }
}

