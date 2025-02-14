using System.Net;
using System.Net.Http.Json;

namespace Design.DependencyInjection.Weather.Api.Weather;

public sealed class OpenWeatherService : IWeatherService
{
    private const string OpenWeatherApiKey = "fa6a800b3eda33a55950295788346ae1";
    private static readonly HttpClient HttpClient = new();
    public async Task<WeatherResponse?> GetCurrentWeatherAsync(string city)
    {
        var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={OpenWeatherApiKey}&units=metric";

        var weatherResponse = await HttpClient.GetAsync(url);

        if (weatherResponse.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }
        // var weather = await weatherResponse.Content.ReadFromJsonAsync<WeatherResponse>();
        return await weatherResponse.Content.ReadFromJsonAsync<WeatherResponse>();

    }
}

