using Design.DependencyInjection.Weather.Api.Services;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Design.DependencyInjection.Weather.Api.Filters;

public class LifeTimeIndicatorFilter : IActionFilter
{
    private readonly IdGeneratorService _idGeneratorService;

    private readonly ILogger<LifeTimeIndicatorFilter> _logger;

    public LifeTimeIndicatorFilter(IdGeneratorService idGeneratorService, ILogger<LifeTimeIndicatorFilter> logger)
    {
        _idGeneratorService = idGeneratorService;
        _logger = logger;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        var id = _idGeneratorService.Id;
        _logger.LogInformation($"{nameof(OnActionExecuted)} id was : {id}");
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var id = _idGeneratorService.Id;
        _logger.LogInformation($"{nameof(OnActionExecuted)} id was : {id}");
    }
}
