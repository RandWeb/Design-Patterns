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
public class InstagramCollection : ISocialNetworkCollection
{
    public Profile[] Profiles => [
        new("Instagram name 1","Instagram email 1 ", TypeOfGender.Male),
        new("Instagram name 2","Instagram email 2 ",TypeOfGender.Female),
        new("Instagram name 3","Instagram email 3 ", TypeOfGender.Male),
        new("Instagram name 4","Instagram email 4 ",TypeOfGender.Female),
        ];
    public ProfileIterator CreateFeMaleIterator() => new InstagramIterator(this, TypeOfGender.Female);

    public ProfileIterator CreateMaleIterator() => new InstagramIterator(this, TypeOfGender.Male);
}

