namespace GISProject;

//Real Subject
public class GISService : IGISService
{
    private readonly Dictionary<string, string> _map = new()
    {
        {"Tehran","35.7000,51.4167" },
        {"Mashhad","36.3069,59.6042" },
        {"Eşfahān","32.6447,51.6675" },
        {"Karaj","35.8327,50.9915" },
        {"Tabrīz","38.0833,46.2833" },
        {"Shīrāz","29.6100,52.5425" },
        {"Qom","34.6461,50.8789" },
        {"Ahvāz","31.3203,48.6692" },
        {"Kermānshāh","34.3167,47.0686" },
        {"Orūmīyeh","37.5486,45.0675" },
        {"Rasht","37.2833,49.6000" },
        {"Kermān","30.2833,57.0667" },
    };

    public string GetLatLng(string name)
    {
        Thread.Sleep(5000);
        return _map.FirstOrDefault(x => x.Key == name).Value;
    }
}
