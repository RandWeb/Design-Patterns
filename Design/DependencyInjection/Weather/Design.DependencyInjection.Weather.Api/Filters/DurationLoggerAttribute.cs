using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Design.DependencyInjection.Weather.Api.Filters;

public class DurationLoggerAttribute : Attribute, IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var sw = Stopwatch.StartNew();
        try
        {
            await next();
        }
        catch
        {
            var logger = context.HttpContext.RequestServices.GetService<ILogger<DurationLoggerAttribute>>();
            logger!.LogInformation($"Request with name {context.ActionDescriptor.DisplayName} completed in {sw.ElapsedMilliseconds}");
        }
    }
}
