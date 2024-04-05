
//client
ISocialNetworkCollection social = new LinkedinCollection();
var profiles = social.CreateMaleIterator();

while (profiles.HasNext)
    Console.WriteLine(profiles.Next);
while (profiles.IsFirst)
    Console.WriteLine(profiles.Previous);

