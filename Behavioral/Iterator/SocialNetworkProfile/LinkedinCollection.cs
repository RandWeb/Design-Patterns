// See https://aka.ms/new-console-template for more information





/// <summary>
/// iterator
/// </summary>

/// <summary>
/// concrete Iterator
/// </summary>
/// <summary>
/// concrete Iterator
/// </summary>
/// <summary>
/// Aggregate
/// </summary>
/// <summary>
/// Concrete Aggregate
/// </summary>
public class LinkedinCollection : ISocialNetworkCollection
{
    public Profile[] Profiles => [
        new("Linkedin name 1","Linkedin email 1 ",TypeOfGender.Male),
        new("Linkedin name 2","Linkedin email 2 ",TypeOfGender.Female),
        new("Linkedin name 3","Linkedin email 3 ",TypeOfGender.Male),
        new("Linkedin name 4","Linkedin email 4 ",TypeOfGender.Female),
        ];
    public ProfileIterator CreateFeMaleIterator() => new LinkedInIterator(this, TypeOfGender.Female);

    public ProfileIterator CreateMaleIterator() => new LinkedInIterator(this, TypeOfGender.Male);


}

