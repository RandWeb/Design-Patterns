namespace GISProject;

//Proxy
public class GISServiceProxy : IGISService
{
    static readonly Dictionary<string, string> _mapCache = new();
    static readonly GISService _gisServicce = new();
    public string GetLatLng(string name)
    {
        var requestOn = DateTime.Now.TimeOfDay;
        if (!_mapCache.ContainsKey(name))
        {
            var latLng = _gisServicce.GetLatLng(name);

            if (!string.IsNullOrWhiteSpace(latLng)) _mapCache.TryAdd(name, latLng);
            else throw new Exception("Given Geo not found");
        }
        var responseOn = DateTime.Now.TimeOfDay;
        return $"Geo: {name}, Sent: {requestOn}, Recived: {responseOn}, Reponse:{_mapCache[name]}";
    }
}
