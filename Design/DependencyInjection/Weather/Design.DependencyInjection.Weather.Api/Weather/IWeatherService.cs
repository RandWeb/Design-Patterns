namespace Design.DependencyInjection.Weather.Api.Weather;

public interface IWeatherService
{
    Task<WeatherResponse?> GetCurrentWeatherAsync(string city);
}

