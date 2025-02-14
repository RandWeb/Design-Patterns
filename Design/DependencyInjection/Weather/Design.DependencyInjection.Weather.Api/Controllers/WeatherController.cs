using Design.DependencyInjection.Weather.Api.Weather;
using Microsoft.AspNetCore.Mvc;

namespace Design.DependencyInjection.Weather.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{

    private readonly IWeatherService _weatherService;

    private readonly ILogger<WeatherController> _logger;

    public WeatherController(ILogger<WeatherController> logger, IWeatherService weatherService)
    {
        _logger = logger;
        _weatherService = weatherService;
    }

    [HttpGet("{city}")]
    public async Task<IActionResult> GetAsync([FromRoute] string city)
    {
        var weater = await _weatherService.GetCurrentWeatherAsync(city);

        if (weater is null) return NotFound();

        return Ok(weater);
    }
}
