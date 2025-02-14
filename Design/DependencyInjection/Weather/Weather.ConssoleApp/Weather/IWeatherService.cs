namespace Design.DependencyInjection.Weather.ConssoleApp.Weather;

public interface IWeatherService
{
    Task<WeatherResponse?> GetCurrentWeatherAsync(string city);
}

