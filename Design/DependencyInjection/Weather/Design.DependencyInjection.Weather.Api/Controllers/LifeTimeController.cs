using Design.DependencyInjection.Weather.Api.Filters;
using Design.DependencyInjection.Weather.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design.DependencyInjection.Weather.Api.Controllers;

[ApiController]
[Route("api/{controller}")]
public class LifeTimeController : ControllerBase
{
    private readonly IdGeneratorService _idGeneratorService;

    public LifeTimeController(IdGeneratorService idGeneratorService)
    {
        _idGeneratorService = idGeneratorService;
    }

    [HttpGet]
    [ServiceFilter(typeof(LifeTimeIndicatorFilter))]
    public async Task<IActionResult> GetIdAsync()
    {
        var id = _idGeneratorService.Id;

        return Ok(id);
    }
}
