using Design.DependencyInjection.Weather.ConssoleApp.Weather;
using System.Text.Json;

namespace Design.DependencyInjection.Weather.ConssoleApp;
public sealed class Application
{
    private readonly IWeatherService _weatherService;

    public Application(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task RunAsync(string[] args)
    {
        var city = args[0];
        var weather = await _weatherService.GetCurrentWeatherAsync(city);
        var serializedWeather = JsonSerializer.Serialize(weather, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        Console.WriteLine(serializedWeather);
    }
}
