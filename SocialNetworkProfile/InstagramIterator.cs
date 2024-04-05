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
public class InstagramIterator : ProfileIterator
{
    public InstagramIterator(InstagramCollection instagram, TypeOfGender gender)
    {
        _profiles = instagram.Profiles.Where(p => p.Gender == gender).ToArray();
    }
}

