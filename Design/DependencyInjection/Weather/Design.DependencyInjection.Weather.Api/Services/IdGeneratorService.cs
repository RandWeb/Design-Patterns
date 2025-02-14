using Microsoft.AspNetCore.Mvc.Filters;

namespace Design.DependencyInjection.Weather.Api.Services;

public class IdGeneratorService 
{
    public Guid Id { get; } = Guid.NewGuid();
}
