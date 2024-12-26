// See https://aka.ms/new-console-template for more information





/// <summary>
/// iterator
/// </summary>
/// <summary>
/// concrete Iterator
/// </summary>
public class LinkedInIterator : ProfileIterator
{
    public LinkedInIterator(LinkedinCollection linkedin, TypeOfGender gender)
    {
        _profiles = linkedin.Profiles.Where(p => p.Gender == gender).ToArray();
    }
}

